using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogmarScore : MonoBehaviour
{
    public static double score;
}

public class LogmarAlgorithm : MonoBehaviour
{
    public const int TOTAL_LETTERS = 40;
    public const int LETTERS_PER_ROW = 5;
    public const int TOTAL_LETTER_ROW_NUMBER = 8;
    public const int STARTING_LETTER_COL = 5;
    public const int STARTING_LETTER_ROW = 1;
    
    public static readonly char[,] logmarChart = new char[TOTAL_LETTER_ROW_NUMBER,LETTERS_PER_ROW]
    {
        {'K', 'Z', 'S', 'C', 'R'},
        {'S', 'C', 'N', 'N', 'H'},
        {'Z', 'V', 'R', 'N', 'S'},
        {'H', 'K', 'N', 'Z', 'D'},
        {'R', 'K', 'D', 'D', 'C'},
        {'N', 'Z', 'O', 'N', 'Z'},
        {'H', 'K', 'K', 'H', 'O'},
        {'D', 'O', 'Z', 'O', 'Z'}
    };
    
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
        letterRow = STARTING_LETTER_ROW - 1;
        letterCol = STARTING_LETTER_COL - 1;
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
            if (isCorrectLetter(letterRow, letterCol, logmarChart, inputLetter)) {              
                if (letterRow == TOTAL_LETTER_ROW_NUMBER - 1) {
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
            if (isCorrectLetter(letterRow, letterCol, logmarChart, inputLetter)) {
                correctAnswersCurrentRow++;
                if (letterCol == LETTERS_PER_ROW - 1) {
                    //End test if number of correct answers is smaller than 3
                    if (correctAnswersCurrentRow < 3) {
                        endTest();
                    } 
                    //Reset number of totalErrors if the whole row is correct
                    else if (correctAnswersCurrentRow == LETTERS_PER_ROW) {
                        totalErrors = 0;
                        correctAnswersCurrentRow = 0;
                    } 
                    //Reset the counter for number of correct answers
                    else {
                        correctAnswersCurrentRow = 0;
                    }
                    if (letterRow == TOTAL_LETTER_ROW_NUMBER - 1) {
                        endTest();
                    }
                    increaseletterRow();                    
                }
                increaseletterCol();
            } else {
                totalErrors++;
                if (letterCol == LETTERS_PER_ROW - 1) {
                    //End test if number of correct answers is smaller than 3 or all letters are finished
                    if (correctAnswersCurrentRow < 3) {
                        endTest();
                    } 
                    //Reset the counter for number of correct answers
                    else {
                        correctAnswersCurrentRow = 0;
                    }
                    //End test if all rows are complete
                    if (letterRow == TOTAL_LETTER_ROW_NUMBER - 1) {
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
        if (letterRow < TOTAL_LETTER_ROW_NUMBER - 1) {
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
            letterRow = TOTAL_LETTER_ROW_NUMBER - 1;
        }
        letterArrowDisplay.DisplayPreviousRow();
    }

    public void increaseletterCol() {
        if (letterCol < LETTERS_PER_ROW - 1) {
            letterCol++;
        } else {
            letterCol = 0;
        }
        letterArrowDisplay.DisplayNextArrow();
    }

    public double calculateScore(int baseline, int totalErrors) {
        double baselineScore = 0;
        switch (baseline)
        {
            case 0:
            baselineScore = 0.8;
            break;
            case 1:
            baselineScore = 0.7;
            break;
            case 2:
            baselineScore = 0.6;
            break;
            case 3:
            baselineScore = 0.5;
            break;
            case 4:
            baselineScore = 0.4;
            break;
            case 5:
            baselineScore = 0.3;
            break;
            case 6:
            baselineScore = 0.2;
            break;
            case 7:
            baselineScore = 0.1;
            break;
        }
        double score = baselineScore + totalErrors*0.02;
        return score;
    }

    public void endTest() {
        LogmarScore.score = calculateScore(letterRow, totalErrors);
        Debug.Log(LogmarScore.score);
        TestSceneNavigation.EndTest();
        return;
    }
}
