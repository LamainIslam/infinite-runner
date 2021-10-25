using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPieceAnimation : MonoBehaviour
{
    public float rotateBy = 100f;
    void Update()
    {
        transform.Rotate(0, rotateBy * Time.deltaTime, 0, Space.Self);
    }
}
