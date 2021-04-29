using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public MainMenu MenuS;
    public string SceneName;
    public string MenuName;
    public GameObject Menu__;
    public GameObject GameOverUI;


  public  void Retry()
    {

        SceneManager.LoadScene(SceneName);


    }
  public  void Menu()

    {
        GameOverUI.SetActive(false);
        Application.Quit();
        MenuS.Isplaying = false;


    }





}
