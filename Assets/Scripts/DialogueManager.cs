using UnityEngine;


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
