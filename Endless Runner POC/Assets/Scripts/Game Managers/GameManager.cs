using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pointsCollected;

    [SerializeField] private GameObject foregroundParticles;
    [SerializeField] private GameObject middlegroundParticles;
    [SerializeField] private GameObject backgroundParticles;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pointsCollected = 0;
        
        Instantiate(foregroundParticles, transform.position, Quaternion.identity);
        Instantiate(middlegroundParticles, transform.position, Quaternion.identity);
        Instantiate(backgroundParticles, transform.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
