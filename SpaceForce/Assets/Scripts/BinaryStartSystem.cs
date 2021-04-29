using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryStartSystem : MonoBehaviour
{

    public float Speed;

    GameObject RoatePoint;
    GameObject MOvePoint;

    public bool CanLerp;
    public float LerpSpeed;


    private void Start()
    {

        RoatePoint = GameObject.FindGameObjectWithTag("RotateStart");
        MOvePoint = GameObject.FindGameObjectWithTag("ShootingStar");

    }

    private void Update()
    {
        if(!CanLerp)
        {

        transform.RotateAround(RoatePoint.transform.position, Vector3.up, Speed * Time.deltaTime);
        }

        if(CanLerp)
        {

            transform.position = Vector3.Lerp(transform.position, MOvePoint.transform.position, LerpSpeed * Time.deltaTime);

        }


    }




}
