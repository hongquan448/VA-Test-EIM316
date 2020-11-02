using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneNavigation : MonoBehaviour
{

    public GameObject resultDisplayWindow;

    public static void ReturnToTitle()
    {
        Debug.Log("Load EndScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToTitle();
        }
        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (resultDisplayWindow.activeSelf == true)
            {
                resultDisplayWindow.SetActive(false);
            }
            else
            {
                resultDisplayWindow.SetActive(true);
            }
        }
    }
}