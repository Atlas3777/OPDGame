using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignManager : MonoBehaviour
{
     public GameObject canvasSing;
     public GameObject DialogePanel;

    public void DisableAllComponents(GameObject gameObject)
    {
        Component[] childComponents = gameObject.GetComponentsInChildren<Component>();

        foreach (Component component in childComponents)
        {
            if (component is Behaviour behaviour)
            {
                behaviour.enabled = false;
            }
        }
    }
    public void EnableAllComponents(GameObject gameObject)
    {
        Component[] childComponents = gameObject.GetComponentsInChildren<Component>();

        foreach (Component component in childComponents)
        {
            if (component is Behaviour behaviour)
            {
                behaviour.enabled = true;
            }
        }
    }


    public void ShowSign()
    {
        canvasSing.SetActive(true);
        DisableAllComponents(DialogePanel);
    }

    public void HideSign()
    {
        EnableAllComponents(DialogePanel);
        canvasSing.SetActive(false);
    }
}
