using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float rotateBy;
    public float moveBy;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotateBy*Time.deltaTime, Space.Self);
        }
        if ( Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotateBy * Time.deltaTime, Space.Self);
        }
        transform.Translate(0,0, -moveBy * Time.deltaTime);
    }
}
/*
FixedUpdate and Time.deltaTime take time into consideration
Time.deltaTime also make the make fair
*/