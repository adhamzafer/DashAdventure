using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles the level start countdown
public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3, countDown2, countDown1, countDownGo; // Countdown UI elements
    public GameObject fadeIn; // Fade-in effect
    public AudioSource readyFX; // Sound effect for countdown
    public AudioSource goFX; // Sound effect for "Go"

    void Start()
    {
        StartCoroutine(CountSequence()); // Start countdown sequence
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true); // Show "3"
        readyFX.Play(); // Play ready sound
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true); // Show "2"
        readyFX.Play(); // Play ready sound
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true); // Show "1"
        readyFX.Play(); // Play ready sound
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true); // Show "Go"
        goFX.Play(); // Play go sound
        PlayerMove.canMove = true; // Enable player movement
    }
}

