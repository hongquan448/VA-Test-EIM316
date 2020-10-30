using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSceneTextDisplay : MonoBehaviour
{
    public GameObject backButton;
    public GameObject endButton;
    public GameObject confirmButton;
    public InputField inputField;
    
    public void Start() {
        backButton.GetComponent<Text>().text = StringsDictionary.buttonString_Back;
        endButton.GetComponent<Text>().text = StringsDictionary.buttonString_End;
        confirmButton.GetComponent<Text>().text = StringsDictionary.buttonString_Confirm;
        inputField.placeholder.GetComponent<Text>().text = StringsDictionary.testSceneString_01;
    }
}
