using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Logbook : MonoBehaviour
{
    [SerializeField] public GameObject phrase;
    [SerializeField] public Transform panelTransform;

    [SerializeField] public static List<string> text = new();

    public static void AddText(string t)
    {
        FileReader.Write(t);
    }

    void Start()
    {
        foreach (string t in FileReader.Read())
        {
            var r = Instantiate(phrase, panelTransform);
            r.GetComponentInChildren<TextMeshProUGUI>().text = t;
        }

    }
}
