using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    [Serializable]
    public struct Data {
        [field: SerializeField] public int sceneid;
        [field: SerializeField] public GlobasVar.Direction direction;
    }

    public static void SaveData(int sceneid, GlobasVar.Direction direction) {
        var d = new Data{sceneid = sceneid, direction = direction};
        Debug.Log(JsonUtility.ToJson(d));
    }
}
