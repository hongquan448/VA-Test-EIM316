using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogmarScoreRight : MonoBehaviour
{
    public static double score;
}

public class LogmarAlgorithmRight : MonoBehaviour
{
    
    public LetterArrowDisplay letterArrowDisplay;
    public InputField inputField;

    public char inputLetter;
    public int letterRow;
    public int letterCol;
    public int totalErrors;
    public int correctAnswersCurrentRow;
    public bool isPerfectVision;

    public void Awake() {
        //Test starts with the last letter of the 1st row
        letterRow = LogmarAlgorithmConstants.STARTING_LETTER_ROW - 1;
        letterCol = LogmarAlgorithmConstants.STARTING_LETTER_COL - 1;
        isPerfectVision = true;
        totalErrors = 0;
        correctAnswersCurrentRow = 0;
        inputField.characterLimit = 1;
        inputField.ActivateInputField();
    }

    //Change text input immediately without the need to select the text box
    public void Update() {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
            ContinueTest();
        } 
        if (Input.GetKeyDown(KeyCode.A)) {
                inputField.text = "A";
        }
        if (Input.GetKeyDown(KeyCode.B)) {
                inputField.text = "B";
        }
        if (Input.GetKeyDown(KeyCode.C)) {
                inputField.text = "C";
        }
        if (Input.GetKeyDown(KeyCode.D)) {
                inputField.text = "D";
        }
        if (Input.GetKeyDown(KeyCode.E)) {
                inputField.text = "E";
        }
        if (Input.GetKeyDown(KeyCode.F)) {
                inputField.text = "F";
        }
        if (Input.GetKeyDown(KeyCode.G)) {
                inputField.text = "G";
        }
        if (Input.GetKeyDown(KeyCode.H)) {
                inputField.text = "H";
        }
        if (Input.GetKeyDown(KeyCode.I)) {
                inputField.text = "I";
        }
        if (Input.GetKeyDown(KeyCode.J)) {
                inputField.text = "J";
        }
        if (Input.GetKeyDown(KeyCode.K)) {
                inputField.text = "K";
        }
        if (Input.GetKeyDown(KeyCode.L)) {
                inputField.text = "L";
        }
        if (Input.GetKeyDown(KeyCode.M)) {
                inputField.text = "M";
        }
        if (Input.GetKeyDown(KeyCode.N)) {
                inputField.text = "N";
        }
        if (Input.GetKeyDown(KeyCode.O)) {
                inputField.text = "O";
        }
        if (Input.GetKeyDown(KeyCode.P)) {
                inputField.text = "P";
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
                inputField.text = "Q";
        }
        if (Input.GetKeyDown(KeyCode.R)) {
                inputField.text = "R";
        }
        if (Input.GetKeyDown(KeyCode.S)) {
                inputField.text = "S";
        }
        if (Input.GetKeyDown(KeyCode.T)) {
                inputField.text = "T";
        }
        if (Input.GetKeyDown(KeyCode.U)) {
                inputField.text = "U";
        }
        if (Input.GetKeyDown(KeyCode.V)) {
                inputField.text = "V";
        }
        if (Input.GetKeyDown(KeyCode.W)) {
                inputField.text = "W";
        }
        if (Input.GetKeyDown(KeyCode.X)) {
                inputField.text = "X";
        }
        if (Input.GetKeyDown(KeyCode.Y)) {
                inputField.text = "Y";
        }
        if (Input.GetKeyDown(KeyCode.Z)) {
                inputField.text = "Z";
        }
    }

    public void ContinueTest() {
        if (inputField.text.Length == 1) {
            inputLetter = char.Parse(inputField.text);
            inputLetter = char.ToUpper(inputLetter);
        } else {
            return;
        }
        //If no mistakes have been made, patient will go through 1st stage of test
        if (isPerfectVision == true) {
            if (isCorrectLetter(letterRow, letterCol, LogmarAlgorithmConstants.logmarChartRight, inputLetter)) {              
                if (letterRow == LogmarAlgorithmConstants.TOTAL_LETTER_ROW_NUMBER - 1) {
                    endTest();
                }
                increaseletterRow();
            } 
            //Returns patient to previous row and registers mistake from patient
            else {
                if (letterRow != 0) {
                    decreaseletterRow();  
                }
                increaseletterCol();                 
                isPerfectVision = false;
            }
        } 
        // if a mistake has been made, patient will proceed to 2nd stage of test
        else {
            if (isCorrectLetter(letterRow, letterCol, LogmarAlgorithmConstants.logmarChartRight, inputLetter)) {
                correctAnswersCurrentRow++;
                if (letterCol == LogmarAlgorithmConstants.LETTERS_PER_ROW - 1) {
                    //End test if number of correct answers is smaller than 3
                    if (correctAnswersCurrentRow < 3) {
                        endTest();
                    } 
                    //Reset number of totalErrors if the whole row is correct
                    else if (correctAnswersCurrentRow == LogmarAlgorithmConstants.LETTERS_PER_ROW) {
                        totalErrors = 0;
                        correctAnswersCurrentRow = 0;
                    } 
                    //Reset the counter for number of correct answers
                    else {
                        correctAnswersCurrentRow = 0;
                    }
                    if (letterRow == LogmarAlgorithmConstants.TOTAL_LETTER_ROW_NUMBER - 1) {
                        endTest();
                    }
                    increaseletterRow();                    
                }
                increaseletterCol();
            } else {
                totalErrors++;
                if (letterCol == LogmarAlgorithmConstants.LETTERS_PER_ROW - 1) {
                    //End test if number of correct answers is smaller than 3 or all letters are finished
                    if (correctAnswersCurrentRow < 3) {
                        endTest();
                    } 
                    //Reset the counter for number of correct answers
                    else {
                        correctAnswersCurrentRow = 0;
                    }
                    //End test if all rows are complete
                    if (letterRow == LogmarAlgorithmConstants.TOTAL_LETTER_ROW_NUMBER - 1) {
                        endTest();
                    }
                    increaseletterRow();                    
                }
                increaseletterCol();
            }
        }
        //Clears the input field for the user automatically
        inputField.text = "";
        inputField.ActivateInputField();
    }
    
    public bool isCorrectLetter(int row, int col, char[,] logmarChart, char inputLetter) {
        if (inputLetter == logmarChart[row,col]) {
            return true;
        } else {
            return false;
        }
    }

    public void increaseletterRow() {
        if (letterRow < LogmarAlgorithmConstants.TOTAL_LETTER_ROW_NUMBER - 1) {
            letterRow++;
        } else {
            letterRow = 0;
        }
        letterArrowDisplay.DisplayNextRow();
    }

    public void decreaseletterRow() {
        if (letterRow > 0) {
            letterRow--;
        } else {
            letterRow = LogmarAlgorithmConstants.TOTAL_LETTER_ROW_NUMBER - 1;
        }
        letterArrowDisplay.DisplayPreviousRow();
    }

    public void increaseletterCol() {
        if (letterCol < LogmarAlgorithmConstants.LETTERS_PER_ROW - 1) {
            letterCol++;
        } else {
            letterCol = 0;
        }
        letterArrowDisplay.DisplayNextArrow();
    }

    

    public void endTest() {
        LogmarScoreRight.score = LogmarAlgorithmConstants.CalculateScore(letterRow, totalErrors);
        Debug.Log(LogmarScoreRight.score);
        TestSceneNavigation.EndTest();
        return;
    }
}
