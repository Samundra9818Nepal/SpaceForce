using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateEachOther : MonoBehaviour
{

    public float Speed;
    public Transform RoatePos;

    // Update is called once per frame
    void Update()
    {


        transform.RotateAround(RoatePos.position, Vector3.up, Speed * Time.deltaTime);
        
    }
}
