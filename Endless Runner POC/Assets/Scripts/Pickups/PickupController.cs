using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    private bool isCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            GameManager.instance.pointsCollected++;
            isCollected = false;
            Destroy(gameObject);
            UIManager.instance.UpdatePickupCount();
        }
    }
}
