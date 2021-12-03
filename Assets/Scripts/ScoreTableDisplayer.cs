using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTableDisplayer : MonoBehaviour
{
    private HighScore highScore;
    public TextMeshProUGUI[] scores;

    void Start()
    {
        highScore = FindObjectOfType<HighScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayScore() 
    {
        for(int i = 0; i < 10; i++)
        {
            scores[i].text = i +". " + (int)highScore.highScores[i];
        }
        
    }
}
