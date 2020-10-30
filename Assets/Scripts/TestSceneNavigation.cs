using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneNavigation : MonoBehaviour
{   
    public static void ReturnToTitleScene() {
        Debug.Log("Load TitleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public static void EndTest() {
        Debug.Log("Load EndScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
