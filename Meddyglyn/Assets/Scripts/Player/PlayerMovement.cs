using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float gravity = 10f;
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float mouseHorizontalSensitivity = 8f;
    [SerializeField] private float mouseVerticalSensitivity = 0.2f;
    [SerializeField] private float verticalClamp = 85f;
    [SerializeField] private Transform playerCamera;
    private float vertRotation = 0f;
    private Vector3 movement;
    private CharacterController playerController;
    private float lookX;
    private float lookY;

    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Horizontal movement
        playerController.Move(movement * moveSpeed * Time.deltaTime);

        //Gravity
        movement.y += gravity * Time.deltaTime;
        Vector3 moveV = new Vector3(0f, movement.y, 0f);
        playerController.Move(moveV * Time.deltaTime);

        //Camera look code
        transform.Rotate(Vector3.up, lookX * Time.deltaTime);
        vertRotation -= lookY;
        vertRotation = Mathf.Clamp(vertRotation, -verticalClamp, verticalClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = vertRotation;
        playerCamera.eulerAngles = targetRotation;

    }

    public void Movement(InputAction.CallbackContext context)
    {
        var moveInput = context.ReadValue<Vector2>();
        float moveInputX = moveInput.x;
        float moveInputY = moveInput.y;
        movement = transform.right * moveInputX + transform.forward * moveInputY;
        //movement = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
    }

    public void MouseLook(InputAction.CallbackContext context)
    {
        var mouseInput = context.ReadValue<Vector2>();
        lookX = mouseInput.x * mouseHorizontalSensitivity;
        lookY = mouseInput.y * mouseVerticalSensitivity;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        
        if (playerController.isGrounded)
        {
            movement.y = jumpForce;
        }
    }

}
