using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterArrowDisplay : MonoBehaviour
{
    //Total number of letters, number of letters per row, and starting arrow position are found in LogmarAlgorithm.cs
    public GameObject[] arrows = new GameObject[LogmarAlgorithm.TOTAL_LETTERS];
    public GameObject[] letterRows = new GameObject[LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER];
    //Array index of the active arrow
    public int activeArrow;
    //Array index of the active letter rwo
    public int activeLetterRow;
    

    void Start() {
        DisableAllArrows(arrows);
        DisableAllLetters(letterRows);
        activeArrow = LogmarAlgorithm.STARTING_LETTER_COL - 1;
        activeLetterRow = LogmarAlgorithm.STARTING_LETTER_ROW - 1;
        letterRows[activeLetterRow].SetActive(true);
        arrows[activeArrow].SetActive(true);
    }

    public void DisplayNextArrow() {
        DisableAllArrows(arrows);
        //Cycle back to the 1st arrow in the row after the last is reached
        if (activeArrow%LogmarAlgorithm.LETTERS_PER_ROW == LogmarAlgorithm.LETTERS_PER_ROW - 1) {
            activeArrow -= (LogmarAlgorithm.LETTERS_PER_ROW - 1);
        } else {
            activeArrow++;
        }
        arrows[activeArrow].SetActive(true);
        return;
    }

    public void DisplayNextRow() {
        DisableAllLetters(letterRows);
        DisableAllArrows(arrows);
        //Cycle back to the 1st letter row after the last is reached
        if (activeLetterRow == LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER - 1) {
            activeLetterRow -= (LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER - 1);
            activeArrow -= ((LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER - 1)*LogmarAlgorithm.LETTERS_PER_ROW);
        } 
        //Display next row of letters and their corresponding arrows
        else {
            activeLetterRow++;
            activeArrow += LogmarAlgorithm.LETTERS_PER_ROW;
        }
        letterRows[activeLetterRow].SetActive(true);
        arrows[activeArrow].SetActive(true);
        return;
    }

    public void DisplayPreviousRow() {
        DisableAllLetters(letterRows);
        DisableAllArrows(arrows);
        //Cycle back to the last letter row after the 1st is reached
        if (activeLetterRow == 0) {
            activeLetterRow += (LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER - 1);
            activeArrow += ((LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER - 1)*LogmarAlgorithm.LETTERS_PER_ROW);
        } 
        //Display previous row of letters and their corresponding arrows
        else {
            activeLetterRow--;
            activeArrow -= LogmarAlgorithm.LETTERS_PER_ROW;
        }
        letterRows[activeLetterRow].SetActive(true);
        arrows[activeArrow].SetActive(true);
        return;
    }

    public void DisableAllArrows(GameObject[] arrows) {
        for(int j = 0; j < LogmarAlgorithm.TOTAL_LETTERS; j++) {
            arrows[j].SetActive(false);
        }
    }

    public void DisableAllLetters(GameObject[] letterRows) {
        for(int i = 0; i < LogmarAlgorithm.TOTAL_LETTER_ROW_NUMBER; i++) {
            letterRows[i].SetActive(false);
        }
    }
}
