using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallEnemyWinZone : MonoBehaviour
{
    public Spawner spawn;
    public GameObject gameOverText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            spawn.work = false;
            Destroy(other.gameObject);

            Debug.Log("Game Over");
            gameOverText.SetActive(true);
            AudioManager.instance.PlayAudio(3);
        }
        
    }
}
