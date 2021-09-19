using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMManager : MonoBehaviour
{
    public float moveBy = 200f;
    public float rotateBy = 20f;
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
}

