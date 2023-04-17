using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject ScoreDisplay;
    public GameObject EndScoreDisplay;
    public int Distance;
    public bool addingDistance = false;


    void Update()
    {
        if (addingDistance == false)
        {
            addingDistance = true;
            StartCoroutine(AddDistance());
        }
    }
    IEnumerator AddDistance()
    {
        Distance += 1;
        ScoreDisplay.GetComponent<Text>().text = "" + Distance;
        EndScoreDisplay.GetComponent<Text>().text = "" + Distance;
        yield return new WaitForSeconds(0.54f);
        addingDistance = false;
        yield return new WaitForSeconds(0.54f);
        
        addingDistance = false;
    }
}

