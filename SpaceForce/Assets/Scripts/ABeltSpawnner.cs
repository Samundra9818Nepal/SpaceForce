using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABeltSpawnner : MonoBehaviour
{
    AsteriodMovement Movement;


    public GameObject[] Asteriods;
    public Transform[] SpwanPoints;
    public int RandonSpawnPointmin, RandonSpawnPointmax;
    public int ASpawnnerMin, ASpawnnerMax;


    public float beat = (60 / 130) * 2;
    public float Timer;


    private void Update()
    {


            Timer += Time.deltaTime;

            if (Timer > beat)
            {


                GameObject Cube = Instantiate(Asteriods[Random.Range(ASpawnnerMin, ASpawnnerMax)], SpwanPoints[Random.Range(RandonSpawnPointmin, RandonSpawnPointmax)]);
                Cube.transform.localPosition = Vector3.zero;
                 Cube.transform.Rotate(transform.forward, 90 * Random.Range(RandonSpawnPointmin, RandonSpawnPointmax));
                Timer -= beat;


            }
        

    }
}
