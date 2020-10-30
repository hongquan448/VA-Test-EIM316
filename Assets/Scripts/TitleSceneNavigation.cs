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

    public void QuitGame() {
        Debug.Log("Exited game");
        Application.Quit();
    }
    
}
