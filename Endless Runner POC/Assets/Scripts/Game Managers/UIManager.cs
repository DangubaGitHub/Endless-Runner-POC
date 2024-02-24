using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text pickupText;
    
    public static UIManager instance;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdatePickupCount();
    }


    void Update()
    {
        
    }

    public void UpdatePickupCount()
    {
        pickupText.text = GameManager.instance.pointsCollected.ToString();
    }
}
