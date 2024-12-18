using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles obstacle collision events
public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer; // Player object
    public GameObject charModel; // Player's character model
    public AudioSource crashThud; // Crash sound effect
    public GameObject mainCam; // Main camera
    public GameObject levelControl; // Level control manager

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false; // Disable obstacle collider
        thePlayer.GetComponent<PlayerMove>().enabled = false; // Disable player movement
        charModel.GetComponent<Animator>().Play("Stumble Backwards"); // Play stumble animation
        levelControl.GetComponent<LevelDistance>().enabled = false; // Stop distance tracking
        crashThud.Play(); // Play crash sound
        mainCam.GetComponent<Animator>().enabled = true; // Enable camera animation
        levelControl.GetComponent<EndRunSequence>().enabled = true; // Trigger end-of-run sequence
    }
}
