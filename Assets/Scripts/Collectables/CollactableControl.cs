using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Controls collectible coin count display
public class CollactableControl : MonoBehaviour
{
    public static int coinCount; // Tracks total coins collected
    public GameObject coinCountDisplay; // In-game coin count UI
    public GameObject coinEndDisplay; // End screen coin count UI

    void Update()
    {
        // Updates coin counts in UI
        coinCountDisplay.GetComponent<TMP_Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TMP_Text>().text = "" + coinCount;
    }
}
