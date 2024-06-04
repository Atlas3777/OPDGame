using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignManager : MonoBehaviour
{
    [SerializeField] private GameObject canvasSing;
    [SerializeField] private GameObject canvasDialoge;

    public void ShowSign()
    {
        canvasSing.SetActive(true);
        canvasDialoge.SetActive(false);

    }

    public void HideSign()
    {
        canvasSing?.SetActive(false);
        canvasDialoge?.SetActive(true);
    }
}
