using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject
{
    public float speed;
    public float maxSpeed = 10;
    public float touchScreenMoveWidth = 6;

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
            /* Dividing width of the screen by variable touchScreenMoveWidth to change the size of the buttons.
             * EX)  (The larger n is, the less wide the buttons are
             *  _________________________
             *  |     |            |     |  Left side is screenWidth/n pixels of the screens width
             *  |  L  |            |  R  |  Right side is screenWidth/(1 and 1/nth) - example: screenwidth/1.1666 if n = 6
             *  |     |            |     |  ^This makes it so the right button starts a little before than the right side of the screen
             *  -------------------------
            */
            if (Input.GetTouch (i).position.x > screenWidth / (1 + 1/touchScreenMoveWidth))    //checks for right side
            {
                move.x = 0.99f;
            }
            if (Input.GetTouch(i).position.x < screenWidth / touchScreenMoveWidth)    //check for left side
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