using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetDestroy : MonoBehaviour
{

    public GameObject AudioClip;
    public GameObject Effects;




    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Stars")
        {
            Destroy(other.gameObject);

            GameObject A = Instantiate(AudioClip, other.transform.position, other.transform.rotation);
            Destroy(A, 1f);

            GameObject E = Instantiate(Effects, other.transform.position, other.transform.rotation);
            Destroy(E, 1f);
        }



        if (other.gameObject.tag == "Blue A")
        {


            Destroy(other.gameObject);

            GameObject A = Instantiate(AudioClip, other.transform.position, other.transform.rotation);
            Destroy(A, 1f);

            GameObject E = Instantiate(Effects, other.transform.position, other.transform.rotation);
            Destroy(E, 1f);




        }



        if (other.gameObject.tag == "Red A")
        {


            Destroy(other.gameObject);

            GameObject A = Instantiate(AudioClip, other.transform.position, other.transform.rotation);
            Destroy(A, 1f);

            GameObject E = Instantiate(Effects, other.transform.position, other.transform.rotation);
            Destroy(E, 1f);




        }




        if (other.gameObject.tag == "Yellow A")
        {



            Destroy(other.gameObject);

            GameObject A = Instantiate(AudioClip, other.transform.position, other.transform.rotation);
            Destroy(A, 1f);

            GameObject E = Instantiate(Effects, other.transform.position, other.transform.rotation);
            Destroy(E, 1f);



        }





    }
}
