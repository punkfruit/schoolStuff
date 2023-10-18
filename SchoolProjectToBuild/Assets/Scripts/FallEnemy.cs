using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEnemy : MonoBehaviour
{
    public PlayerController player;
    public float speed = 5;
    public int scoreValue = 5;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "bullet")
        {
            Destroy(other);
            Destroy(gameObject);
            player.AddScore(scoreValue);
            AudioManager.instance.PlayAudio(2);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
