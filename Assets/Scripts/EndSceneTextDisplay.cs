using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneTextDisplay : MonoBehaviour
{
    
    public GameObject confirmButton;
    public GameObject seeResultsAgainButton;
    public GameObject endSceneString_01;
    public GameObject endSceneString_02;

    // Start is called before the first frame update
    void Start()
    {
        confirmButton.GetComponent<Text>().text = StringsDictionary.buttonString_Confirm;
        seeResultsAgainButton.GetComponent<Text>().text = StringsDictionary.buttonString_SeeResultsAgain;
        endSceneString_01.GetComponent<Text>().text = StringsDictionary.endSceneString_01;
        endSceneString_02.GetComponent<Text>().text = StringsDictionary.endSceneString_02;
    }
}
