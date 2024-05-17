using UnityEngine;

public class dialogueEnter : MonoBehaviour
{
    public GameObject Ebutton;
    private DialogueStory ds;
    private bool isBeen = false;
    void Start()
    {
        ds = GetComponent<DialogueStory>();
    }

    void OnTriggerStay(Collider myCollider)
    {
        if (myCollider.tag == ("Player") && !isBeen) 
        {
            Ebutton.SetActive(true);
            if (Input.GetKey(KeyCode.E)) 
            {
                ds.StartStory();
                isBeen = true;
                Ebutton.SetActive(false);
            }
        }
    }
    void OnTriggerExit(Collider myCollider)
    {
        if (myCollider.tag == ("Player")) 
        {
            Ebutton.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player") && !isBeen)
        {
            // ds.StartStory();
            // isBeen = true;
        }
    }
}
