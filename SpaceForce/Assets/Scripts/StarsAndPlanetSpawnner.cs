using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsAndPlanetSpawnner : MonoBehaviour
{
    AsteriodMovement Movement;
    public MainMenu Menu;

    public GameObject[] Asteriods;
    public Transform[] SpwanPoints;
    public int RandonSpawnPointmin, RandonSpawnPointmax;
    public int ASpawnnerMin, ASpawnnerMax;


    public float beat = (60 / 130) * 2;
    public float Timer;

    public float StopTime;
    public bool IsStopped;


    private void Update()
    {
        if (Menu.Isplaying)
        {



            if (!IsStopped)
            {

                Timer += Time.deltaTime;
                StartCoroutine(StopSpaw());

                if (Timer > beat)
                {


                    GameObject Cube = Instantiate(Asteriods[Random.Range(ASpawnnerMin, ASpawnnerMax)], SpwanPoints[Random.Range(RandonSpawnPointmin, RandonSpawnPointmax)]);
                    Cube.transform.localPosition = Vector3.zero;
                    //  Cube.transform.Rotate(transform.forward, 90 * Random.Range(RandonSpawnPointmin, RandonSpawnPointmax));
                    Timer -= beat;


                }
            }
        }

    }


    IEnumerator StopSpaw()
    {


        yield return new WaitForSeconds(StopTime);
        IsStopped = true;
    }



   
}
