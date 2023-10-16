using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallEnemyWinZone : MonoBehaviour
{
    public PickuoSpawner spawn;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            spawn.work = false;

            Debug.Log("Game Over");
        }
        
    }
}
