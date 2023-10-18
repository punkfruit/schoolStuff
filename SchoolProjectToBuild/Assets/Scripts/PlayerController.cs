using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public Vector2 moveDirection;
    public float speed = 50;
    public GameObject bullet;

    public TextMeshProUGUI text;

    public int Score;

    private void Start()
    {
        AddScore(0);
    }
    private void FixedUpdate()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");

        theRB.velocity = moveDirection * speed;




    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 fireDirection = (mousePosition - (Vector2)transform.position).normalized;

            float rotationAngle = Mathf.Atan2(fireDirection.y, fireDirection.x) * Mathf.Rad2Deg;
            Quaternion bulletRotation = Quaternion.Euler(0, 0, rotationAngle);

            Instantiate(bullet, transform.position, bulletRotation);
            AudioManager.instance.PlayAudio(1);
        }
    }

    public void AddScore(int val)
    {
        Score += val;
        Debug.Log(Score);

        text.text = ("Score: " + Score);
    }
}
