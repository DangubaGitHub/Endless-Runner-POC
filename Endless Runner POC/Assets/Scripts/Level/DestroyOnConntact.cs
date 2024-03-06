using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnConntact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
