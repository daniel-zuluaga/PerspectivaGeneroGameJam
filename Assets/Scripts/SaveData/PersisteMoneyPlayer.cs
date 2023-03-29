using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PersisteMoneyPlayer : ScriptableObject
{
    public void Save(string fileName = null)
    {
        var binaryFormater = new BinaryFormatter();
        FileStream file = File.Create(GetPath(fileName));
        var json = JsonUtility.ToJson(this);

        binaryFormater.Serialize(file, json);
        file.Close();
    }

    public virtual void Load(string fileName = null)
    {
        if (File.Exists(GetPath(fileName)))
        {
            var binaryFor = new BinaryFormatter();
            FileStream file = File.Open(GetPath(fileName), FileMode.Open);

            JsonUtility.FromJsonOverwrite((string)binaryFor.Deserialize(file), this);
            file.Close();
        }
    }

    public string GetPath(string fileName = null)
    {
        var fullFileName = string.IsNullOrEmpty(fileName) ? name : fileName;
        return string.Format("{0}/{1}.json", Application.persistentDataPath, fullFileName);
    }
}
