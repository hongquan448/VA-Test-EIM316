using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResultLeft : MonoBehaviour
{
    public static double testResultLeft;

    // Start is called before the first frame update
    void Start()
    {
        testResultLeft = LogmarScore.score;
    }
}
