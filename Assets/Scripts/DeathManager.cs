using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject EndMenuUI;
    public bool isDead;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isDead = true;
            Time.timeScale = 0f;
            EndMenuUI.SetActive(true);
        }
    }
}
