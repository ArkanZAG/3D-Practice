using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int playerMovementSpeed;
    [SerializeField] private Rigidbody playerRIgidBody;
    [SerializeField] private GameObject visual;

    private Vector3 lastMovement;
    
    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontalInput, 0, verticalInput);
        if (movement.magnitude > 0) lastMovement = movement;
        
        playerRIgidBody.velocity = new Vector3(horizontalInput * playerMovementSpeed, playerRIgidBody.velocity.y , verticalInput * playerMovementSpeed );
        Debug.Log(playerRIgidBody.velocity);
    }

    private void PlayerRotation()
    {
        visual.transform.forward = lastMovement;
    }

    private void Update()
    {
        PlayerMovement();
        PlayerRotation();
    }
}
