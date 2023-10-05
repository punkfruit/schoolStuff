using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float crouchSpeed = 2.5f; 
    public float sprintSpeed = 8f;   
    public float jumpForce = 5f;
    public float gravity = -40f;
    public float mouseSensitivity = 2f;
    public Transform playerCamera;
    public float stamina = 100f; 
    public float staminaDepletionRate = 20f; 
    public float staminaRecoveryRate = 15f; 

    private Vector3 velocity;
    private bool isJumping = false;
    private bool isCrouching = false; 
    private CharacterController controller;
    private float xRotation = 0f;
    private float originalHeight; 

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        originalHeight = controller.height; 
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = !isCrouching;
            controller.height = isCrouching ? originalHeight / 2 : originalHeight;
            moveSpeed = isCrouching ? crouchSpeed : 5f;
        }

        if (Input.GetKey(KeyCode.LeftShift) && !isCrouching && stamina > 0)
        {
            moveSpeed = sprintSpeed;
            stamina -= staminaDepletionRate * Time.deltaTime;
        }
        else if (!isCrouching)
        {
            moveSpeed = 5f;
            stamina += staminaRecoveryRate * Time.deltaTime;
        }
        stamina = Mathf.Clamp(stamina, 0, 100); 

        Vector3 moveDirection = transform.right * x + transform.forward * z;
        Vector3 move = moveDirection.normalized * moveSpeed;
        controller.Move(move * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded && !isCrouching)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
