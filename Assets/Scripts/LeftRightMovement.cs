using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMovement : MonoBehaviour
{
    public float rotateBy;
    private float rotated;
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(0, 0, rotateBy, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotateBy, Space.Self);
        }
    }
}
