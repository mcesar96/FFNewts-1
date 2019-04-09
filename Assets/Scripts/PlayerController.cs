using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public float speed;
    public float maxSpeed = 10;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    //public Vector2 screenHalfSize; // for boundaries
    //private Rigidbody rb;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
 

    // Update is called once per frame
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (move.x >= -0.70f && move.x <= 0.70f) // horizontal movement on axis. change this for start and stop
            animator.SetBool("isRunning", false);
        else
        {
            animator.SetBool("isRunning", true);
 
            animator = GetComponent<Animator>();

            bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f)); // flip sprite?
            if (flipSprite)                                                // flip sprite.
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }

            //animator.SetBool("grounded", grounded); 
            //animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

            targetVelocity = move * maxSpeed;
        }
    }
}