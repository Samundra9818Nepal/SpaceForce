using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public BigFinale Finale;

    public OVRInput.Button ShootButton;
    public GameObject SparkEffects;
    public Transform Point1;
    public Rigidbody Bullet;
    public float LaserForce;
    public AudioClip LaserSound;
    public AudioSource Source;


    [Header ("Special GunFire")]
    public bool SpecialGunFire;
    public Image GunMeter;
    public float GunIntMeter;
    public GameObject LaserGun;
    public GameObject LaserGunSOund;
    public bool CanShoot;
    public float DepleteTime;
    public GameObject SoundEffects;
    public GameObject DeactivateSoundEffect;

    public bool once;
    public bool One1;
    public bool Once;




    public void Update()
    {

        GunMeter.fillAmount = GunIntMeter;

        GunIntMeter = Mathf.Clamp(GunIntMeter, 0f, 1f);


        if (GunIntMeter >= 1f)
        {
            once = true;
            GunIntMeter = 0.99f;

            Once = true;

            if (once)
            {
                GameObject go = Instantiate(SoundEffects, transform.position, Quaternion.identity);
                Destroy(go, 3f);
            }
         





            SpecialGunFire = true;
           


        } else if(GunIntMeter <= 0f)
        {

            SpecialGunFire = false;

            if(SpecialGunFire == false && Once)
            {

                GameObject S = Instantiate(DeactivateSoundEffect, transform.position, Quaternion.identity);
                Destroy(S, 3F);
                Once = false;

            }
        }




        if (OVRInput.GetDown(ShootButton) && !SpecialGunFire)
        {
            Rigidbody LaserIns;
            Source.clip = LaserSound;
                
            Source.Play();

             LaserIns = Instantiate(Bullet, Point1.transform.position,Point1.transform.rotation) as Rigidbody;
             LaserIns.AddForce(transform.forward * LaserForce);


            GameObject LaserEffects = Instantiate(SparkEffects, Point1.transform.position, Point1.transform.rotation);
            Destroy(LaserEffects, 1f);
        }






        if (OVRInput.Get(ShootButton) && SpecialGunFire && Finale.IsBigFinale ==false)
        {

            Source.clip = LaserSound;
            GameObject LaserEffects = Instantiate(LaserGun, Point1.transform.position, Point1.transform.rotation);
            LaserEffects.GetComponent<Rigidbody>().AddForce(transform.forward * LaserForce);
            Destroy(LaserEffects, 1f);

            GameObject Gsound = Instantiate(LaserGunSOund, Point1.transform.position, Point1.transform.rotation);
            Destroy(Gsound, 0.5f);


            Source.Play();
            GunIntMeter -= DepleteTime * Time.deltaTime;

        }


        if (Finale.IsBigFinale)
        {

            GameObject LaserEffects = Instantiate(LaserGun, Point1.transform.position, Point1.transform.rotation);
            LaserEffects.GetComponent<Rigidbody>().AddForce(transform.forward * LaserForce);
            Destroy(LaserEffects, 1f);

            GameObject Gsound = Instantiate(LaserGunSOund, Point1.transform.position, Point1.transform.rotation);
            Destroy(Gsound, 0.5f);


        }


    }


 


}
