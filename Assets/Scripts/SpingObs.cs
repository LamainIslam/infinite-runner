using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObs : MonoBehaviour
{
    private float rotateBy = 30f;
    private int mode = 1;

    void Start()
    {
        mode = Random.Range(1, 4);
        switch (mode) {
            case 1:
                rotateBy = 20f;
                break;
            case 2:
                rotateBy = 30f;
                break;
            case 3:
                rotateBy = -20f;
                break;
            case 4:
                rotateBy = -30f;
                break;
        }   
    }
    void Update()
    {
        transform.Rotate(0, 0, rotateBy* Time.deltaTime);
    }
}
