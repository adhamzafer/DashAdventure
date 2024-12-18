using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles player movement and jumping
public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5; // Forward movement speed
    public float leftRightSpeed = 4; // Side movement speed
    static public bool canMove = false; // Controls if the player can move
    public bool isJumping = false; // Checks if the player is jumping
    public bool comingDown = false; // Checks if the player is descending from a jump
    public GameObject playerObject; // Reference to the player object
    public float jumpingSpeed = 3; // Jumping speed

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World); // Move forward

        if (canMove) // If movement is allowed
        {
            // Move left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide) 
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }

            // Move right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }

            // Jump
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                if (!isJumping) // Only jump if not already jumping
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jumping Up"); // Play jump animation
                    StartCoroutine(JumpSequence()); // Start jump sequence
                }
            }
        }

        // Handle jumping movement
        if (isJumping)
        {
            if (!comingDown) // Going up
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpingSpeed, Space.World);
            }
            else // Coming down
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpingSpeed * -1, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.6f); // Pause at jump apex
        comingDown = true; // Start coming down
        yield return new WaitForSeconds(0.6f); // Pause before ending jump
        isJumping = false; // Reset jump state
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Running"); // Return to running animation
    }
}
