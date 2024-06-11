using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameScript : MonoBehaviour
{
    public Transform block;
    private List<Transform> blocks = new();
    public Transform panel;
    public Scrollbar scroll;
    public BoxCollider2D basck;
    private float CurrentTime = 0;
    private float PreviusTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime - PreviusTime > 1) {
            PreviusTime = CurrentTime;
            var newBlock = Instantiate(block, panel);
            newBlock.GetComponent<Rigidbody2D>().gravityScale = 1;
            blocks.Add(newBlock);
            newBlock.localPosition = new Vector3(Random.Range(-800, 800), 600);
        }
        foreach (var block in blocks.Where(block => block.position.y < -200)) block.gameObject.SetActive(false);
        foreach (var block in blocks.Where(block => basck.IsTouching(block.GetComponent<BoxCollider2D>()))) block.gameObject.SetActive(false);
        blocks.RemoveAll(block => {if (!block.gameObject.activeSelf) {Destroy(block.gameObject); return true;} return false;});
        if (Input.GetKey(KeyCode.A))
        {
            scroll.value -= 0.7f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            scroll.value += 0.7f * Time.deltaTime;
        }
    }
}

