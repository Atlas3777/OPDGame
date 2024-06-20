using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public float _speed = 5;
    [SerializeField] public GameObject floor;
    private SpriteRenderer sr;

    public Animator anim;

    public bool stop = false;
    //TODO: �������� Offset x/y
    void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        if (anim is null)
            anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene("MainMenu");
        anim.SetFloat("move", 0);
        if (!stop) 
        { 
            if (Input.GetKey(KeyCode.W))
            {
                var newPosition = transform.position + new Vector3(0, 0, 1) * _speed * Time.deltaTime;
                newPosition.z = Mathf.Clamp(newPosition.z, -floor.transform.localScale.z/2, floor.transform.localScale.z / 2);      
                transform.position = newPosition;
                anim.SetFloat("move", 2);
            }
                

            if (Input.GetKey(KeyCode.S))
            {
                var newPosition = transform.position + new Vector3(0, 0, -1) * _speed * Time.deltaTime;
                newPosition.z = Mathf.Clamp(newPosition.z, -floor.transform.localScale.z / 2, floor.transform.localScale.z / 2);
                transform.position = newPosition;
                anim.SetFloat("move", 2);
            }
                
            if (Input.GetKey(KeyCode.A))
            {
                sr.flipX = false;
                var newPosition = transform.position + new Vector3(-1, 0, 0) * _speed * Time.deltaTime;
                newPosition.x = Mathf.Clamp(newPosition.x, -floor.transform.localScale.x / 2, floor.transform.localScale.x / 2);      
                transform.position = newPosition;
                anim.SetFloat("move", 2);
            }


            if (Input.GetKey(KeyCode.D))
            {
                sr.flipX = true;
                var newPosition = transform.position + new Vector3(1, 0, 0) * _speed * Time.deltaTime;
                newPosition.x = Mathf.Clamp(newPosition.x, -floor.transform.localScale.x / 2, floor.transform.localScale.x / 2);
                transform.position = newPosition;
                anim.SetFloat("move", 2);
            }
        }
    }

    public void Stop() {
        stop = true;
    }

    public void Star() {
        Stop();
    }
}
