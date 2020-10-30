using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResultExport : MonoBehaviour
{
    private static readonly string SAVE_FOLDER = Application.dataPath + "/Results/";  

    public static void Save() {
        //Checks if save folder exists
        if (!Directory.Exists(SAVE_FOLDER)) {
            //Creates save folder if non is found
            Directory.CreateDirectory(SAVE_FOLDER);
        }
        
        string filePath = DateTime.Now.ToString();
        filePath = filePath.Replace(":", ".").Replace("/", "-");
        filePath = SAVE_FOLDER + "Test Result " + filePath + ".txt";
        Debug.Log(filePath);        
        SaveObject saveObject = new SaveObject {
            dateTime = DateTime.Now.ToString(),
            score = LogmarScore.score
        };
        string json = JsonUtility.ToJson(saveObject);
        Debug.Log(json);
        File.WriteAllText(filePath, json);
    }

    private class SaveObject {
        public string dateTime;
        public double score;
    }
}
