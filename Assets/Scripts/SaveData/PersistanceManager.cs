using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistanceManager : MonoBehaviour
{
    private const string fileName = "infoPlayer.data";

    public InfoPlayer saveObject;

    private void OnEnable()
    {
        Load();
    }

    private void OnDisable()
    {
        Save();
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

        if (File.Exists(path))
        {
            string playerInfojson = File.ReadAllText(path);

            InfoPlayer playerInfo = JsonUtility.FromJson<InfoPlayer>(playerInfojson);

            saveObject.moneyPlayer = playerInfo.moneyPlayer;
            saveObject.yaComproProducto = playerInfo.yaComproProducto;
        }
    }
}
