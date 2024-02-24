using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pointsCollected;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pointsCollected = 0;
    }


    void Update()
    {
        
    }
}
