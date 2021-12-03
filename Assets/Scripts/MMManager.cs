using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMManager : MonoBehaviour
{
    private ScoreTableDisplayer scoreTD;

    public float moveBy = 200f;
    public float rotateBy = 20f;
    public bool howToPlayMenuIsOpen = false;
    public bool scoreMenuIsOpen = false;

    public GameObject howToPlayMenuUI;
    public GameObject scoreMenuUI;
    public GameObject settingMenuUI;

    private void Start()
    {
        scoreTD = FindObjectOfType<ScoreTableDisplayer>();
    }
    void FixedUpdate()
    {
        transform.Translate(0, 0, -moveBy * Time.deltaTime);
        transform.Rotate(0, 0, rotateBy * Time.deltaTime);
    }

    public void start()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();//close the game
    }

    public void HowToPlay() 
    {
        if (howToPlayMenuIsOpen == false)
        {
            howToPlayMenuUI.SetActive(true);
            howToPlayMenuIsOpen = true;
        }
        else if (howToPlayMenuIsOpen == true)
        {
            howToPlayMenuUI.SetActive(false);
            howToPlayMenuIsOpen = false;
        }
    }

    //mistake-----------------------------------------
    /*
     * 
     * 
     * 
     * 
     public void HowToPlay() 
    {
        if (howToPlayMenuIsOpen == false)
        {
            howToPlayMenuUI.SetActive(true);
            mainMenu.SetActive(false);
            howToPlayMenuIsOpen = true;

    -----------------------------------------------------------------------
    how to play is a child of mainMenu
    mainMenu.SetActive(false); was removed because it doesnt make a different as the main meun gets covered by the howToPlayMenu anyways
    -----------------------------------------------------------------------

        }

    -----------------------------------------------------------------------
    should be else if not if (undoes the if statement before)
    -----------------------------------------------------------------------

        if (howToPlayMenuIsOpen == true)
        {
            howToPlayMenuUI.SetActive(false);
            mainMenu.SetActive(true);
            howToPlayMenuIsOpen = false;
        }
    }
     */

    public void scoreMenu() 
    {
        if (scoreMenuIsOpen == false)
        {
            scoreMenuUI.SetActive(true);
            scoreMenuIsOpen = true;
            scoreTD.displayScore();
        }
        else if (scoreMenuIsOpen == true)
        {
            scoreMenuUI.SetActive(false);
            scoreMenuIsOpen = false;
        }
    }

    public void settingMenu()
    {
        settingMenuUI.SetActive(true);
    }
}

