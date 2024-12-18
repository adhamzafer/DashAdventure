using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generates level sections dynamically
public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section; // Array of level sections
    public int zPos = 50; // Z position for the next section
    public bool creatingSection = false; // Check if a section is being created
    public int secNum; // Random section index

    void Update()
    {
        if (!creatingSection) 
        {
            creatingSection = true; // Start generating a section
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection() 
    {
        secNum = Random.Range(0, 3); // Pick a random section
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity); // Spawn the section
        zPos += 50; // Update Z position for the next section
        yield return new WaitForSeconds(5); // Wait before generating the next section
        creatingSection = false; // Allow new section creation
    }
}
