using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public float speed;
    public float maxSpeed = 10;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private float screenWidth;

    //public Vector2 screenHalfSize; // for boundaries
    //private Rigidbody rb;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        screenWidth = Screen.width;
    }
 

    // Update is called once per frame
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        int i = 0;
        while(i < Input.touchCount) //for movement by tapping the side
        {
            if (Input.GetTouch (i).position.x > screenWidth / 1.166)    //checks if tapping right side of the screen (the right 1/3 of screen)
            {
                move.x = 0.99f;
            }
            if (Input.GetTouch(i).position.x < screenWidth / 6)    //same for left
            {
                move.x = -0.99f;
            }
            i++;
        }

        if (move.x >= -0.30f && move.x <= 0.30f) // horizontal movement on axis. change this for start and stop
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