using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Updates distance display
public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay, disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.75f;

    void Update()
    {
        if (!addingDis)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun++;
        disDisplay.GetComponent<TMP_Text>().text = "" + disRun;
        disEndDisplay.GetComponent<TMP_Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
