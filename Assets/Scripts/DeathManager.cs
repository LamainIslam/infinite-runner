using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    private HighScore highScore;
    public ScoreManager scoreManager;
    public GameObject EndMenuUI;
    public bool isDead;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        highScore = FindObjectOfType<HighScore>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isDead = true;
            Time.timeScale = 0f;
            EndMenuUI.SetActive(true);
            highScore.highScores[11] = scoreManager.highScore;
            highScore.bubbleSortHighscores();
        }
    }
}
