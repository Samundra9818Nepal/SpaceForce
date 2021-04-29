using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovements : MonoBehaviour
{
    public float Speed;
    public float ScrollSpeed;
    Renderer rend;


    private void Start()
    {


        rend = GetComponent<Renderer>();
    }


    private void Update()
    {


        float offset = Time.time * ScrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        transform.position += Time.deltaTime * Speed * -Vector3.forward;
        transform.Rotate(0, 5F * Time.deltaTime, 0f);

    }

}
