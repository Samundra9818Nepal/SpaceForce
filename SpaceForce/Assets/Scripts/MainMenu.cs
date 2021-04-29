using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource Source;
    public bool Isplaying;
    public GameObject Menu;
   


    public void Start()
    {
        Isplaying = false;
        Source.Stop();

    }


    private void Update()
    {
        
        if(!Isplaying)
        {
            Source.Stop();

        }

    }


    public void Play()
    {


        GetComponent<BigFinale>().enabled = true;
        Source.Play();
        Isplaying = true;
        Menu.SetActive(false);

    }



    public void Quit()
    {


        Application.Quit();
    }

 

}
