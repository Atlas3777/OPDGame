using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveS : MonoBehaviour
{
    private Rigidbody rb;
    private float HorizontalMove = 0f;
    private float VerticalMove = 0f;
    private bool FacingRight = true;


    public Animator anim;
    public float speed = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        VerticalMove = Input.GetAxisRaw("Vertical") * speed;

        if (HorizontalMove < 0 && FacingRight || HorizontalMove > 0 && !FacingRight) 
        {
            Flip();
        }
        if (Math.Abs(HorizontalMove) > 0 || Math.Abs(VerticalMove) > 0) anim.SetFloat("move", 1);
        else anim.SetFloat("move", 0);
    }
    private void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector3(HorizontalMove * 5f, 0, VerticalMove * 5f);
        rb.velocity = targetVelocity;
    }

    private void Flip()
    {
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
