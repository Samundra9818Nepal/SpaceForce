using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BarrierCheck : MonoBehaviour
{








    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Blue A"))
        {

            Destroy(other.gameObject);
           
        

        }


        if (other.gameObject.CompareTag("Red A"))
        {

            Destroy(other.gameObject);
           


        }

        if (other.gameObject.CompareTag("Yellow A"))
        {

            Destroy(other.gameObject);
           



        }



        if (other.gameObject.CompareTag("Stars"))
        {

            Destroy(other.gameObject);




        }



    }


}
