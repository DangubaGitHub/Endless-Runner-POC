using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vector2 = System.Numerics.Vector2;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
   
    [SerializeField] float moveSpeed;
   
    
    [Header("Jumping")]
    
    [SerializeField] float jumpForce;
    [SerializeField] bool isGrounded;
    [SerializeField] float isGroundedRadius;
    [SerializeField] Transform feetPosition;
    [SerializeField] LayerMask whatIsGround;
    private float jumpTimeCounter;
    [SerializeField] float jumpTime;
    private bool isJumping;

    [Header("Extras")] 
    
    public bool isStarting;
    
    public Rigidbody2D rb2d;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
        isStarting = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, isGroundedRadius,whatIsGround);

        if (isStarting == true)
        {
            rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
        }
        
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            //rb2d.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                //rb2d.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}
