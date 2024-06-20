using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int playerMovementSpeed;
    [SerializeField] private Rigidbody playerRIgidBody;
    
    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRIgidBody.velocity = new Vector3(horizontalInput * playerMovementSpeed, playerRIgidBody.velocity.y , verticalInput * playerMovementSpeed );
        Debug.Log(playerRIgidBody.velocity);
    }

    private void Update()
    {
        PlayerMovement();
    }
}
