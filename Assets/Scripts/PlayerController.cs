﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public float maxSpeed = 10;

    private SpriteRenderer spriteRenderer;
    private Animator animator;
   // public KeyCode run1;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator> ();
    }


    // Update is called once per frame
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;
        /*
        if (Input.GetKeyDown(run1))
        {
            animator.SetTrigger("NewtMove");
        }
        */
        move.x = Input.GetAxis("Horizontal");   // look up docs for unity object 
                                                // if 0 do idle animation
                                                // else do other animation

        if (move.x == 0)
        {
            animator.SetTrigger("NewtMove");
        }
      
        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if(flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }
}
