using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMovements : MonoBehaviour
{
    public float Speed;
    public float ScrollSpeed;
    Renderer rend;
    public float SpeedIncrease;
    GameObject Manager;
    bool Vibrate;
    bool CanSpeed = true;
    GameObject[] Sh;


    private void Start()
    {

        Manager = GameObject.FindGameObjectWithTag("Manager");
        Sh = GameObject.FindGameObjectsWithTag("Gun");

        rend = GetComponent<Renderer>();
    }


    private void Update()
    {

        foreach (var S in Sh)
        {

            if(S.GetComponent<Shooting>().SpecialGunFire)
            {

                Speed += 0.2f;

            }
            if (Manager.GetComponent<ScoreManager>().Score > 50f && S.GetComponent<Shooting>().SpecialGunFire == false)
            {
                Speed += 0.1f;
            }

        }


        float offset = Time.time * ScrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        transform.position += Time.deltaTime * Speed * -Vector3.forward;
        transform.Rotate(0, 30f * Time.deltaTime, 0f);


       

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            Vibrate = true;
            if (Vibrate)
            {
                OVRInput.SetControllerVibration(0.1f, 2f, OVRInput.Controller.RTouch);
                OVRInput.SetControllerVibration(0.1f, 2f, OVRInput.Controller.LTouch);

                StartCoroutine(StopVibrate());
            }

          

        }

       
        }

    

    IEnumerator StopVibrate()
    {


        yield return new WaitForSeconds(1f);
        if(Vibrate)
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
            Vibrate = false;
        }
}





}
