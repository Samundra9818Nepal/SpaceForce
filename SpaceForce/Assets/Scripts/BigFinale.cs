using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFinale : MonoBehaviour
{

    [Header("Shooting Stars")]
    public Transform[] StartingPoint;
    public GameObject Stars;
    public int max, min;
    public float timer = 5f;

    [Header("Final")]
    public Transform First;
    public Transform Second;
    public Transform Third;
    public Transform Foruth;

    [Header("Places")]
    public GameObject Planst;
    public GameObject Plannd;
    public GameObject Planrd;
    public GameObject Planth;

    public bool PlanerSpawn;

    public bool IsBigFinale;

    public bool IsStopped;
    public bool GameOverUI;
    public GameObject GameOverUIScreen;
    public bool ISArrived;
    public Transform Point;
    public GameObject Portal;
    public Spawnner SP;
    public GameObject[] ShootingStar;
    public Transform Position;
  

    [Header("Timer")]
    public float Timer;

    private void Start()
    {

        PlanerSpawn = true;

        GameOverUIScreen.SetActive(false);
        GameOverUI = false;
        Portal.SetActive(false);
        IsStopped = false;
        ISArrived = false;
        IsBigFinale = false;
    }
    private void Update()
    {
        if(IsBigFinale)
        {
            ShootingStarsMoving();

        }

        if(IsStopped)
        {
        Portal.transform.position = Vector3.MoveTowards(Portal.transform.position, Point.transform.position, 20f * Time.deltaTime);

        }

        if(Vector3.Distance(Portal.transform.position , Point.transform.position) <= 1f)
        {
            IsStopped = true;
            ISArrived = true;

        }

        
        if(SP.BigFinaleTime && !GameOverUI)
        {
            Portal.SetActive(true);
            GetComponent<AudioSource>().Play();
            IsStopped = true;
           
        }


        if(ISArrived && !GameOverUI)
        {
            IsBigFinale = true;

           

            if(PlanerSpawn)
            {

                SpawnPlanetsandStars();
                PlanerSpawn = false;

            }




            StartCoroutine(StopTheFinalae());
            Timer += 3F * Time.deltaTime;

            if (Timer >= 5f)
            {

                GameObject Spawnner = Instantiate( ShootingStar[Random.Range(0 , ShootingStar.Length)], Position.transform.position, Position.transform.rotation);
                
               
                Timer = 0f;
            }


        }


    }

    IEnumerator StopTheFinalae()
    {


       yield return new WaitForSeconds(20f);
        GetComponent<AudioSource>().Stop();

        IsBigFinale = false;
        Portal.SetActive(false);
        GameOverUI = true;
        GameOverUIScreen.SetActive(true);
        Debug.Log("Done");
        GetComponent<BigFinale>().enabled = false;
    }


  public void SpawnPlanetsandStars()
    
    {
 Instantiate(Planst, First.transform.position, First.transform.rotation);

       Instantiate(Plannd, Second.transform.position, Second.transform.rotation);



       Instantiate(Planrd, Third.transform.position, Third.transform.rotation);



Instantiate(Planth, Foruth.transform.position, Foruth.transform.rotation);



    }




    public void ShootingStarsMoving()
    {

        timer -= 3f * Time.deltaTime;
        if (timer <= 0f)
        {
            timer = 5f;

            GameObject Spawnner = Instantiate(Stars, StartingPoint[Random.Range(min, max)]);
            Destroy(Spawnner, 20f);
        }



    }


}
