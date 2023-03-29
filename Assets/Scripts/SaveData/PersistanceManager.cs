using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistanceManager : MonoBehaviour
{
    public List<PersisteMoneyPlayer> saveObject;

    private void OnEnable()
    {
        for (int i = 0; i < saveObject.Count; i++)
        {
            var saveObj = saveObject[i];
            saveObj.Load();
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < saveObject.Count; i++)
        {
            var saveObj = saveObject[i];
            saveObj.Save();
        }
    }
}
