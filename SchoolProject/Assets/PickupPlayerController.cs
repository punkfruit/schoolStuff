using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public Vector2 moveDirection;
    public float speed = 50;

    public int inventory;
    private void FixedUpdate()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");

        theRB.velocity = moveDirection * speed;


    }

    public void AddInventory()
    {
        inventory++;

        Debug.Log(inventory);
    }
}
