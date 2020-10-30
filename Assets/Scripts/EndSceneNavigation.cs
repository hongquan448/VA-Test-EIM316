using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneNavigation : MonoBehaviour
{
    public static void ReturnToTitle() {
        Debug.Log("Load EndScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
