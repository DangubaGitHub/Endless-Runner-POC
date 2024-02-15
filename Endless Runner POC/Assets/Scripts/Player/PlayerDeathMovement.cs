using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    private bool isMoving;

    public Rigidbody2D rb2d;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        isMoving = true;
    }
    
    void Update()
    {
        if (isMoving)
        {
            rb2d.AddForce(transform.right * moveSpeed, ForceMode2D.Impulse);
            isMoving = false;
        }
        
    }
}
