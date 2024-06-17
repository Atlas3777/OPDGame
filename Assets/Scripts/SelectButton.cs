using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    [SerializeField] TextMesh textMesh;

    public void OnMouseEnter()
    {
        textMesh.color = Color.red;  
        
    }

    public void OnMouseExit()
    {
        textMesh.color = Color.white;
    }
}
