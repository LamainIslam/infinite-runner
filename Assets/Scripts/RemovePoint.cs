using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePoint : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreManager.scoreAmount -= 5f;
            Debug.Log("-point");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            scoreManager.scoreAmount -= 5f;
            Debug.Log("-point");
        }
    }
}
