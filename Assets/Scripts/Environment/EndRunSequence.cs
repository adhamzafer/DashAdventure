using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Manages the end-of-run sequence
public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins; // UI for live coin count
    public GameObject liveDis; // UI for live distance
    public GameObject endScreen; // End screen UI
    public GameObject fadeOut; // Fade-out effect

    void Start()
    {
        StartCoroutine(EndSequence()); // Start the end sequence
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3); // Wait for 3 seconds
        liveCoins.SetActive(false); // Hide coin count UI
        liveDis.SetActive(false); // Hide distance UI
        endScreen.SetActive(true); // Show end screen
        yield return new WaitForSeconds(3); // Wait for 3 seconds
        fadeOut.SetActive(true); // Show fade-out effect
        yield return new WaitForSeconds(2); // Wait for 2 seconds
        SceneManager.LoadScene(0); // Reload the scene
    }
}
