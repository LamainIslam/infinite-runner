using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//to be able to change the scenes 
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    public static bool isPaused = false;//so the game knows if we are pausing or resumeing
    public GameObject pauseMenuUI;
    public GameObject EndMenuUI;
    public GameObject pauseBNT;
    //public Text pauseBNT;
    private DeathManager deathManager;

    private void Start()
    {
        deathManager = FindObjectOfType<DeathManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused && deathManager.isDead != true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            /*
            if (Input.GetKeyDown(KeyCode.Escape)) 
            { 
                TogglePause();
                pauseBNT = isPaused ? "X" : "Y";
            }*/
        }
    }

    /*public void TogglePause()
    {
        isPaused = !isPaused; // invert
        pauseMenuUI.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
        // this is like if (GameIsPaused) ? this value : otherwise this value;
    }*/
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();//close the game
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
        EndMenuUI.SetActive(false);
    }
}
