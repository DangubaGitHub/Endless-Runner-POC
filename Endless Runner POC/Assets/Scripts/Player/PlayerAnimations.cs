using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    string currentState;
    
    const string MOVE = "anim_move";
    const string JUMP = "anim_jump";
    const string IDLE = "anim_idle";

    
    public Animator anim;
    public Rigidbody2D rb2d;
    
    public static PlayerAnimations instance;

    private void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        ChangeAnimationState(IDLE);
    }
    
    void Update()
    {
        if (PlayerController.instance.isGrounded)
        {
            if (rb2d.velocity.x > 0.1f)
            {
                ChangeAnimationState(MOVE);
            }
        }

        if (PlayerController.instance.isGrounded == false)
        {
            if (rb2d.velocity.y > 0.1f)
            {
                ChangeAnimationState(JUMP);
            }
        }
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        anim.Play(newState);
        currentState = newState;
    }
}
