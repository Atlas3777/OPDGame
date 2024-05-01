using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    private PlayerMoveS PlayerMove;
    public TextMeshProUGUI text_panel;
    public Transform panel;


    void Start()
    {
        PlayerMove = player.GetComponent<PlayerMoveS>();


    }
    public void StartDialogue()
    {
        PlayerMove.speed = 0; 
        anim.SetBool("start", true);
    }
    public void StopDialogue()
    {
        PlayerMove.speed = 1; 
        anim.SetBool("start", false);
    }
}
