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
        scoreDisplayLeft.text = LogmarScoreLeft.score.ToString();
        scoreDisplayRight.text = LogmarScoreRight.score.ToString();

        Debug.Log(LogmarScoreLeft.score);
        Debug.Log(LogmarScoreRight.score);
        TestResultExport.Save();
    }
}
