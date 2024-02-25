using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    private float moveSpeed = 15f;

    private Rigidbody2D rb2d;
    
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }


    void Update()
    {
        if (PlayerController.instance.isStarting)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
    }
}
