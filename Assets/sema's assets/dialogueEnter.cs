using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class dialogueEnter : MonoBehaviour
{
    private DialogueStory ds;
    private bool isBeen = false;
    void Start()
    {
        ds = GetComponent<DialogueStory>();
    }
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player") && !isBeen)
        {
            ds.StartStory();
            isBeen = true;
        }
    }
}
