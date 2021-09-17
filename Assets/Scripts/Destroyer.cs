using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameObject player;
    public float distance;
    private float distanceToPop = 1001f;
    public bool poped = false;

    void Start()
    {
        if (player == null)
            player = GameObject.FindWithTag("Player");
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if ((distance > distanceToPop) && (poped == false))
        {
            Destroy(gameObject);
            poped = true;
        }
    }
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if ((distance > distanceToPop) && (poped == false))
        {
            Destroy(gameObject);
            poped = true;
        }
    }
}
