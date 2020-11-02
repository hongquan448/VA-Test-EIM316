using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogmarAlgorithmConstants
{
    public const int TOTAL_LETTERS = 55;
    public const int LETTERS_PER_ROW = 5;
    public const int TOTAL_LETTER_ROW_NUMBER = 11;
    public const int STARTING_LETTER_COL = 5;
    public const int STARTING_LETTER_ROW = 1;

    public static readonly char[,] logmarChartLeft = new char[TOTAL_LETTER_ROW_NUMBER, LETTERS_PER_ROW]
    {
        {'D', 'S', 'R', 'K', 'N'},
        {'K', 'K', 'Z', 'O', 'H'},
        {'O', 'N', 'R', 'K', 'D'},
        {'K', 'Z', 'V', 'D', 'C'},
        {'V', 'S', 'H', 'Z', 'O'},
        {'H', 'D', 'K', 'C', 'R'},
        {'C', 'S', 'R', 'H', 'N'},
        {'S', 'V', 'Z', 'D', 'K'},
        {'N', 'C', 'V', 'O', 'Z'},
        {'R', 'H', 'S', 'D', 'V'},
        {'S', 'N', 'R', 'O', 'H'}
    };

    public static readonly char[,] logmarChartRight = new char[TOTAL_LETTER_ROW_NUMBER, LETTERS_PER_ROW]
    {
        {'H', 'V', 'Z', 'D', 'S'},
        {'N', 'C', 'V', 'K', 'D'},
        {'C', 'Z', 'S', 'H', 'N'},
        {'O', 'N', 'V', 'S', 'R'},
        {'K', 'D', 'N', 'R', 'O'},
        {'Z', 'K', 'C', 'S', 'V'},
        {'D', 'V', 'O', 'H', 'C'},
        {'O', 'H', 'V', 'C', 'K'},
        {'H', 'Z', 'C', 'K', 'O'},
        {'N', 'C', 'K', 'H', 'D'},
        {'Z', 'H', 'C', 'S', 'R'}
    };

    public static double CalculateScore(int baseline, int totalErrors)
    {
        double baselineScore = 0;
        switch (baseline)
        {
            case 0:
                baselineScore = 1.0;
                break;
            case 1:
                baselineScore = 0.9;
                break;
            case 2:
                baselineScore = 0.8;
                break;
            case 3:
                baselineScore = 0.7;
                break;
            case 4:
                baselineScore = 0.6;
                break;
            case 5:
                baselineScore = 0.5;
                break;
            case 6:
                baselineScore = 0.4;
                break;
            case 7:
                baselineScore = 0.3;
                break;
            case 8:
                baselineScore = 0.2;
                break;
            case 9:
                baselineScore = 0.1;
                break;
            case 10:
                baselineScore = 0.0;
                break;
        }
        double score = baselineScore + totalErrors * 0.02;
        return score;
    }
}
