using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
   
    [SerializeField] float moveSpeed;
   
    
    [Header("Jumping")]
    
    [SerializeField] float jumpForce;
    public bool isGrounded;
    [SerializeField] float isGroundedRadius;
    [SerializeField] Transform feetPosition;
    [SerializeField] LayerMask whatIsGround;
    private float jumpTimeCounter;
    [SerializeField] float jumpTime;
    private bool isJumping;

    
    [Header("Game Objects")] 
    
    [SerializeField] GameObject Moving;
    [SerializeField] GameObject Jumping;


    [Header("Extras")] 
    
    [SerializeField] bool isAlive;
    public bool isStarting;
    public Rigidbody2D rb2d;
    public SpriteRenderer sr;
    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        isStarting = false;
        isAlive = true;
    }

    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, isGroundedRadius,whatIsGround);

        if (isAlive)
        {
            if (isStarting == true)
            {
                rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
            }

            if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            }

            if (Input.GetKey(KeyCode.Space) && isJumping == true)
            {
                if (jumpTimeCounter > 0)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
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
        
        else if (!isAlive)
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isAlive = false;
            
            if (isGrounded)
            {
                Moving.SetActive(true);
                sr.enabled = false;
                Debug.Log("Collision Working");
            }

            if (!isGrounded)
            {
                Jumping.SetActive(true);
                sr.enabled = false;
            }
        }
    }
}
