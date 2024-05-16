using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class Logbook : MonoBehaviour
{
    [SerializeField] public GameObject phrase;
    [SerializeField] public Transform panelTransform;

    public SceneLoadInfo h = new SceneLoadInfo();

    [SerializeField] public static List<string> text = new();

    public static void AddText(string t)
    {
        FileReader.Write("example.txt", t);
    }

    void Start()
    {
        foreach (string t in FileReader.Read("example.txt"))
        {
            var r = Instantiate(phrase, panelTransform);
            r.GetComponentInChildren<TextMeshProUGUI>().text = t;
        }
        
    }
}
