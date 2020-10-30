using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestResultDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreDisplay;


    void Start()
    {
        string finalScore = LogmarScore.score.ToString();
        scoreDisplay.text = finalScore;    
        Debug.Log(LogmarScore.score);
        TestResultExport.Save();
    }

    
}
