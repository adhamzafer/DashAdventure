using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles coin collection behavior
public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX; // Sound effect for coin collection

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play(); // Play coin sound
        CollactableControl.coinCount += 1; // Increase coin count
        this.gameObject.SetActive(false); // Deactivate collected coin
    }
}
