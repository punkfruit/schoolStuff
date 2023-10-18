using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickup : MonoBehaviour
{
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pickup")
        {

            Destroy(other.gameObject);
        }

    }
}
