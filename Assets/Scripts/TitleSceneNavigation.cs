using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneNavigation : MonoBehaviour
{

    public void StartTest() {
        Debug.Log("Load TestScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitProgram() {
        Debug.Log("Exited program");
        Application.Quit();
    }

    //Change text input immediately without the need to select the text box
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitProgram();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            LanguageSelect.SelectEnglish();
            StartTest();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            LanguageSelect.SelectChinese();
            StartTest();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            LanguageSelect.SelectMalay();
            StartTest();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            LanguageSelect.SelectTamil();
            StartTest();
        }
    }

}
