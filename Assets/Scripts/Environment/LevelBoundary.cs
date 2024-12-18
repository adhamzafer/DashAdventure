using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Defines level boundaries
public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -4.3f; // Left boundary
    public static float rightSide = 4.3f; // Right boundary
    public float internalLeft; // Internal reference for the left boundary
    public float internalRight; // Internal reference for the right boundary

    void Update()
    {
        internalLeft = leftSide; // Update internal left boundary
        internalRight = rightSide; // Update internal right boundary
    }
}
