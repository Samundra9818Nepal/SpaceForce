using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollpaseScript : MonoBehaviour
{

    public GameObject As;
    public bool Canisn;
    public GameObject sp;
    public bool GameoverUI;
    public GameObject DestroySoundEffect;
    bool Once;

    public void Start()
    {

        sp = GameObject.FindGameObjectWithTag("SP");


    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "RotateStart")
        {



            Canisn = true;
            Once = true;
        }


    }





    public void Update()
    {
        

        if(Canisn)
        {

            GetComponent<MeshRenderer>().enabled = false;
            GameObject Go =   Instantiate(As, transform.position, transform.rotation);

            if(Once)
            {
              Instantiate(DestroySoundEffect, transform.position, transform.rotation);
                Once = false;
            }


            Destroy(Go, 3f);
            StartCoroutine(WaitTime());
        }


        if(GameoverUI)
        {


            sp.GetComponent<Spawnner>().GameOverUI.SetActive(true);

        }




    }




    IEnumerator WaitTime()
    {

        yield return new WaitForSeconds(20f);
        Canisn = false;
        GameoverUI = true;
    }

}
