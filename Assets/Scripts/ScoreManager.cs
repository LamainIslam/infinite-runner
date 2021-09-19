using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float pointIncreasedPerSecond;
    private float scoreAmount;
    private float highScore;
    public float HighS;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    void Update()
    {
        score.text = "" + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;

        if (highScore < scoreAmount)//only updates high Score if there is a new highScore(start)
        {
            highScore = scoreAmount;
        }
        if (highScore > PlayerPrefs.GetFloat("highScore"))
        {
            PlayerPrefs.SetFloat("highScore", highScore);//stores high score even if game is closed 
            score.color = Color.red;
            HighS = PlayerPrefs.GetFloat("highScore");
        }                           //only updates high Score if there is a new highScore
    }
}
