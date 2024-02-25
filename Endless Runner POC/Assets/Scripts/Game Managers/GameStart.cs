using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] float gameStartTime;
    
    
    void Start()
    {
       
    }

    void Update()
    {
        gameStartTime -= Time.deltaTime;
        
        if (gameStartTime <= 0)
        {
            PlayerController.instance.isStarting = true;
        }
    }
}
