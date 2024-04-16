using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    private PlayerMoveS pm;

    void Start()
    {
        pm = player.GetComponent<PlayerMoveS>();
    }
    public void StartDialogue()
    {
        pm.speed = 0; 
        anim.SetBool("start", true);
    }
    public void StopDialogue()
    {
        pm.speed = 1; 
        anim.SetBool("start", false);
    }
}
