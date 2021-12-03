using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float pointIncreasedPerSecond;
    public float scoreAmount = 0f;
    public float highScore;
    public float HighS;

    private ObstacleMovement obstacleMovement;

    void Start()
    {
        obstacleMovement = FindObjectOfType<ObstacleMovement>();

        scoreAmount = 0f;
        pointIncreasedPerSecond = obstacleMovement.moveBy/170;
    }

    void Update()
    {
        score.text = "" + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
        pointIncreasedPerSecond = (obstacleMovement.moveBy / 170);

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
