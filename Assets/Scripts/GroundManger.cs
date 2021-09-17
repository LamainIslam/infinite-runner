using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManger : MonoBehaviour
{
    public GameObject[] groundPieces;
    public GameObject player;
    public GameObject manager;
    public Transform parent;
    private float distance;
    private float maxSpawnDistanceFromPlayer = 1000f;
    public bool spawned = false;
    public int randomIndex;
    public float zrot;
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        if (manager == null)
        {
            manager = GameObject.FindWithTag("Manager");
        }
        if (parent == null)
        {
            parent = manager.transform;
        }
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        zrot = Random.Range(0, 360);
        randomIndex = Random.Range(0, groundPieces.Length);//picks one of the item from the list
        if ((distance < maxSpawnDistanceFromPlayer) && (spawned == false))
        {
            GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, transform.rotation);//clones the picked item and spawns it
            clone.transform.Rotate(new Vector3(0, 0, zrot));
            clone.transform.SetParent(parent);
            spawned = true;
        }
        //GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, Quaternion.identity);//clones the picked item and spawns it
    }
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        zrot = Random.Range(0, 360);
        if ((distance < maxSpawnDistanceFromPlayer) && (spawned == false))
        {
            GameObject clone = Instantiate(groundPieces[randomIndex], transform.position, transform.rotation);//clones the picked item and spawns it
            clone.transform.Rotate(new Vector3(0, 0, zrot));
            clone.transform.SetParent(parent);
            spawned = true;
        }
        if (spawned == true){ Destroy(gameObject); } 
    }
}
