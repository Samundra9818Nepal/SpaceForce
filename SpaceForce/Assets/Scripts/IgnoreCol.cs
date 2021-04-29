using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCol : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Physics.IgnoreCollision(transform.GetComponent<Collider>(), Player.GetComponent<CharacterController>());


        
    }
}
