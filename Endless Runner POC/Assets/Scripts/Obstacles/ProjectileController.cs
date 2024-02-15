using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    [SerializeField] float speed;
    public bool isActive;

    public Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        isActive = false;
    }
    
    void Update()
    {
        if (isActive)
        {
            rb2d.velocity = Vector2.left * speed;
        }
    }
}
