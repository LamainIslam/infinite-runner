using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawaner : MonoBehaviour
{
    public GameObject[] obstacle;
    public int randomIndex;
    public float xrot;
    public float yrot;
    public float zrot;
    void Start()
    {
        randomIndex = Random.Range(0, obstacle.Length);
        xrot = Random.Range(-30, 30);
        yrot = Random.Range(-30, 30);
        zrot = Random.Range(0, 360);
        GameObject clone = Instantiate(obstacle[randomIndex], transform.position, transform.rotation,transform.parent);
        clone.transform.Rotate(new Vector3(xrot, yrot, zrot));
        Destroy(gameObject);
    }
}
