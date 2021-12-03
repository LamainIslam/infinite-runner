using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public float[] highScores = {0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f};
    private float temp = 0f;

    public void bubbleSortHighscores() { 
        for (int i = 0; i < highScores.Length; i++)
        {
            for (int j = 0; j < highScores.Length - 1; j++)
            {
                if (highScores[j] > highScores[j + 1])
                {
                    temp = highScores[j + 1];
                    highScores[j + 1] = highScores[j];
                    highScores[j] = temp;
                }       
            }   
        }
    }
}
