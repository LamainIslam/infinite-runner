using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManger : MonoBehaviour
{
    public GameObject[] groundPieces;
    public GameObject player;
    public float distance;
    public float maxSpawnDistanceFromPlayer = 100f;
    public bool spawned = false;
    public int randomIndex;
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        randomIndex = Random.Range(0, groundPieces.Length);//picks one of the item from the list
        if ((distance < maxSpawnDistanceFromPlayer) && (spawned == false))
        {
            GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, transform.rotation);//clones the picked item and spawns it
            spawned = true;
        }
            //GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, Quaternion.identity);//clones the picked item and spawns it
    }
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if ((distance < maxSpawnDistanceFromPlayer) && (spawned == false))
        {
            GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, transform.rotation);//clones the picked item and spawns it
            spawned = true;
        }
    }
}
