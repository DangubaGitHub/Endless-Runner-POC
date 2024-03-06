using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float timeTillDestroyed;
    
    
    void Start()
    {
        
    }


    void Update()
    {
        timeTillDestroyed -= Time.deltaTime;
        
        if (timeTillDestroyed <= 0)
        {
            Destroy(gameObject);
        }
    }
}
