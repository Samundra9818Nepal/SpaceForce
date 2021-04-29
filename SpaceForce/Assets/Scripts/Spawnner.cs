using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public MainMenu menu;
    public Shooting[] ST;
    public ScoreManager Score;
    public GameObject GameOverUI;
    public GameObject[] Asteriods;
    public Transform[] SpwanPoints;
    public int RandonSpawnPointmin, RandonSpawnPointmax;
    public int ASpawnnerMin, ASpawnnerMax;

    public float StopTime;
    public bool IsStopped;


    public float beat = (60 /130) *2;
    public float Timer;

    public bool BigFinaleTime;

    private void Start()
    {


        GameOverUI.SetActive(false);

    }

    private void Update()
    {
        foreach (var S in ST)
        {
            if (S.SpecialGunFire)
            {

                beat = 0.1f;

            }
            else
            {

                beat = 0.3f;

            }
        }



        if (menu.Isplaying)
        {


            if (!IsStopped)
            {

                Timer += Time.deltaTime;
                StartCoroutine(StopSpaw());

                if (Timer > beat)
                {


                    GameObject Cube = Instantiate(Asteriods[Random.Range(ASpawnnerMin, ASpawnnerMax)], SpwanPoints[Random.Range(RandonSpawnPointmin, RandonSpawnPointmax)]);
                    Cube.transform.localPosition = Vector3.zero;
                    Cube.transform.Rotate(transform.forward, 90 * Random.Range(RandonSpawnPointmin, RandonSpawnPointmax));
                    Timer -= beat;


                }


                /* if(Score.Score >= 20)
                 {

                     beat = 0.2f;

                 }*/
            }
        }
       

    }


    IEnumerator StopSpaw()
    {


        yield return new WaitForSeconds(StopTime);
        IsStopped = true;
        BigFinaleTime = true;
      
    }


}
