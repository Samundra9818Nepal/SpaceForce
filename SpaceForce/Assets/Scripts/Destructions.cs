using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructions : MonoBehaviour
{
    public GameObject Asteriods;
    public GameObject BlueA;

    public GameObject YellowA;

    public GameObject RedA;


    public GameObject BlastAudio;

    GameObject[] FindGun;

    public float IncreaseLevel;



    GameObject Manager;
    private void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("Manager");
        FindGun = GameObject.FindGameObjectsWithTag("Gun");

        Destroy(gameObject, 2f);


    }



    private void Update()
    {
        

    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "FinalEnding")

        {
             Destroy(other.gameObject);

            GameObject Blue = Instantiate(BlueA, transform.position, transform.rotation);
            Destroy(Blue, 1f);
            GameObject A = Instantiate(BlastAudio, transform.position, transform.rotation);
            Destroy(A, 1f);



        }




        if (other.gameObject.tag == "Planets")
        {


            GameObject A = Instantiate(BlastAudio, transform.position, transform.rotation);
            Destroy(A, 1f);
            Destroy(other.gameObject);

            
                GameObject Blue = Instantiate(Asteriods, transform.position, transform.rotation);

                Destroy(Blue, 2f);
            
         

        }



        if (other.gameObject.CompareTag("Blue A"))
        {
            Manager.GetComponent<ScoreManager>().CurrentScore += 1;
            foreach (var G in FindGun)
            {

                G.GetComponent<Shooting>().GunIntMeter += IncreaseLevel;


            }

            Destroy(other.gameObject);

            GameObject Blue = Instantiate(BlueA, transform.position, transform.rotation);
            GameObject A = Instantiate(BlastAudio, transform.position, transform.rotation);
            Destroy(A, 1f);
            Destroy(Blue, 2f);

          
        }


        if (other.gameObject.CompareTag("Red A"))
        {
            Manager.GetComponent<ScoreManager>().CurrentScore += 1;
            foreach (var G in FindGun)
            {

                G.GetComponent<Shooting>().GunIntMeter += IncreaseLevel;


            }

            Destroy(other.gameObject);
           
            GameObject Red = Instantiate(RedA, transform.position, transform.rotation);
            GameObject A = Instantiate(BlastAudio, transform.position, transform.rotation);
            Destroy(A, 1f);
            Destroy(Red, 2f);
           

        }

        if (other.gameObject.CompareTag("Yellow A"))
        {

            Manager.GetComponent<ScoreManager>().CurrentScore += 1;
            foreach (var G in FindGun)
            {

                G.GetComponent<Shooting>().GunIntMeter += IncreaseLevel;


            }

            Destroy(other.gameObject);
          
            GameObject Yellow = Instantiate(YellowA, transform.position, transform.rotation);
            GameObject A = Instantiate(BlastAudio, transform.position, transform.rotation);
            Destroy(A, 1f);
            Destroy(Yellow, 2f);


        }



    }




}
