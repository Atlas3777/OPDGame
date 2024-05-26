using System;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{
    [Serializable]
    public struct Data {
        [field: SerializeField] public string sceneName;
        [field: SerializeField] public GlobasVar.Direction direction;
    }

    public static void SaveData(string sceneName, GlobasVar.Direction direction) {
        var d = new Data{sceneName = sceneName, direction = direction};
        FileReader.Cleer("save.txt");
        FileReader.Write("save.txt", JsonUtility.ToJson(d));
    }
}
