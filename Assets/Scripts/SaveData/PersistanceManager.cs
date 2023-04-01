using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistanceManager : MonoBehaviour
{
    private const string fileName = "infoPlayer.data";

    public InfoPlayer saveObject;

    private float curTimeSave = 1f;

    private void OnEnable()
    {
        Load();
        Save();
    }

    private void OnDisable()
    {
        Save();
    }

    private void Update()
    {
        curTimeSave -= Time.deltaTime;
        if (curTimeSave <= 0)
        {
            Save();
            curTimeSave = 2.5f;
        }
    }

    public void Save()
    {
        string playerInfoJson = JsonUtility.ToJson(saveObject);
        string path = Path.Combine(Application.persistentDataPath, fileName);
        File.WriteAllText(path, playerInfoJson);
        Debug.Log(playerInfoJson);
        Debug.Log(path);
    }

    public void Load()
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        string playerInfojson = File.ReadAllText(path);

        InfoPlayer playerInfo = JsonUtility.FromJson<InfoPlayer>(playerInfojson);

        saveObject.moneyPlayer = playerInfo.moneyPlayer;
        saveObject.yaComproProducto = playerInfo.yaComproProducto;
    }
}
