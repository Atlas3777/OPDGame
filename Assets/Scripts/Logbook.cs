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
        text.Add(t);
    }

    public void Start()
    {
        foreach (string t in text)
        {
            var r = Instantiate(phrase, panelTransform);
            r.GetComponentInChildren<TextMeshProUGUI>().text = t;
        }

    }
}
