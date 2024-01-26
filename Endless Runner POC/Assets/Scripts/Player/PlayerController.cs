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
    
    
    
    public Rigidbody2D rb2d;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, isGroundedRadius,whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpForce;
        }
    }
}
