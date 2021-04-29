using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMovement : MonoBehaviour
{

    GameObject Player;

    public float Speed;

    public GameObject Audio;
    public GameObject Effect;
    public GameObject Asteriods;




    private void Start()
    {

        Player = GameObject.FindGameObjectWithTag("Player");

    }



    private void Update()
    {

        transform.position = Vector3.Lerp(transform.position, Player.transform.position, Speed * Time.deltaTime);

    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);

        }


        if (other.gameObject.tag == "Laser")
        {



            Destroy(this.gameObject);
            GameObject go = Instantiate(Audio, transform.position, transform.rotation);
            Destroy(go, 1f);
          GameObject Newgo =   Instantiate(Effect, transform.position, transform.rotation);
            Destroy(Newgo, 1f);


            for (int i = 0; i < 10; i++)
            {

            GameObject Yo =    Instantiate(Asteriods, transform.position, transform.rotation);
                Destroy(Yo, 3f);
            }



        }

    }


}
