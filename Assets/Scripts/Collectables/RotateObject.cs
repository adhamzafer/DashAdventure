using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rotates the object
public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 0.1f; // Speed of rotation

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotate the object around the Y-axis
    }
}
