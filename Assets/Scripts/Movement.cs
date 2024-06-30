using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int playerMovementSpeed;
    [SerializeField] private Rigidbody playerRIgidBody;
    [SerializeField] private GameObject visual;
    [SerializeField] private Animator playerAnimator;

    private Vector3 lastMovement;
    
    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontalInput, 0, verticalInput);
        if (movement.magnitude > 0)
        {
            lastMovement = movement;
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.C))
        {
            playerRIgidBody.velocity = new Vector3(horizontalInput * playerMovementSpeed * 0.5f,
                playerRIgidBody.velocity.y, verticalInput * playerMovementSpeed * 0.5f);
            
            playerAnimator.SetBool("isCrouching", true);
        }
        else
        {
            playerRIgidBody.velocity = new Vector3(horizontalInput * playerMovementSpeed, playerRIgidBody.velocity.y , verticalInput * playerMovementSpeed );
            playerAnimator.SetBool("isCrouching", false);
        }
        
        
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
