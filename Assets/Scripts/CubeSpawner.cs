using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public float raycastDistance = 50f;
    public float overlapBoxSize = 1f;
    public LayerMask spawnedObjectLayer;
    void Start()
    {
        //cube = GameObject.FindWithTag("Cube-obs");
        PositionRaycast();
    }

    void PositionRaycast()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, raycastDistance))
        {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

           Vector3 overlapTestBoxScale = new Vector3(overlapBoxSize, overlapBoxSize, overlapBoxSize);
            Collider[] collidersInsideOverlapBox = new Collider[1];
            int numberOfCollidersFound = Physics.OverlapBoxNonAlloc(hit.point, overlapTestBoxScale, collidersInsideOverlapBox, spawnRotation, spawnedObjectLayer);

            if (numberOfCollidersFound == 0)
            {
                pick(hit.point, spawnRotation);
            }
            else
            {
                Debug.Log("name of collider 0 found " + collidersInsideOverlapBox[0].name);
            }
        }
    }

    void pick(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        //int randomIndex = Random.Range(0, list.Length);
        GameObject clone = Instantiate(cube, positionToSpawn, rotationToSpawn, transform.parent);
        //GameObject clone = Instantiate(list[randomIndex], hit.point, spawnRotation);   
    }
}
