using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject EndMenuUI;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer == 3)
        {
            Time.timeScale = 0f;
            EndMenuUI.SetActive(true);
        }
    }
}
