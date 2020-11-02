using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestResultDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreDisplayLeft;
    public TMP_Text scoreDisplayRight;

    void Start()
    {
        scoreDisplayLeft.text = TestResultLeft.testResultLeft.ToString();
        scoreDisplayRight.text = TestResultRight.testResultRight.ToString();

        Debug.Log(LogmarScore.score);
        TestResultExport.Save();
    }

}
