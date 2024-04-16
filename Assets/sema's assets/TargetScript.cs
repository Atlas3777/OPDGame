using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public Transform a;
    public Transform b;

    [Range(0, 1f)]public float am;
    private Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var NewPosition = a.position + (b.position - a.position) * am;
        NewPosition.y = 0.5f; 
        tr.position = NewPosition;
    }
}
