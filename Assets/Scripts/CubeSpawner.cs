using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        cube = GameObject.FindWithTag("Cube-obs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
