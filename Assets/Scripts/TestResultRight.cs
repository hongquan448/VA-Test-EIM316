using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResultRight : MonoBehaviour
{
    public static double testResultRight;

    // Start is called before the first frame update
    void Start()
    {
        testResultRight = LogmarScore.score;
    }
}
