using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject Moving;
    [SerializeField] GameObject Jumping;
    [SerializeField] GameObject PlayerMain;

    public static PlayerCollision instance;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }
    
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision other)
    {
        
        
    }
}
