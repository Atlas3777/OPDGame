using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    private PlayerMove PlayerMove;


    void Start()
    {
        PlayerMove = player.GetComponent<PlayerMove>();

    }
    public void StartDialogue()
    {
        PlayerMove.stop = true; 
        anim.SetBool("start", true);
    }
    public void StopDialogue()
    {
        PlayerMove.stop = false; 
        anim.SetBool("start", false);
    }
}
