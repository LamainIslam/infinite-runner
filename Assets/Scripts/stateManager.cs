using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//to be able to change the scenes 
using UnityEngine.UI;

public class stateManager : MonoBehaviour
{
    public static bool GameIsPaused = false;//so the game knows if we are pausing or resumeing
    public GameObject pauseMenuUI;
    //public GameObject pauseBNT;
    //public Text pauseBNT;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            /*if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }*/
            if (Input.GetKeyDown(KeyCode.Escape)) 
            { 
                TogglePause();
//                pauseBNT.text = GameIsPaused ? "X" : "Y";
            }
        }
    }

    //new code allows to make a pause button in the game UI
    public void TogglePause()
    {
        GameIsPaused = !GameIsPaused; // invert
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = GameIsPaused ? 0f : 1f;
        // this is like if (GameIsPaused) ? this value : otherwise this value;
    }
    /*public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }*/

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();//close the game
    }

}
