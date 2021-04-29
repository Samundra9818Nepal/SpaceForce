using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodMovement : MonoBehaviour
{


    public float Speed;
    public float SpeedIncrease;

   

    private void Update()
    {

       
        transform.position += Time.deltaTime * Speed * -Vector3.forward;
        transform.Rotate(0, 90 * Time.deltaTime, 0f);

    }




  


}
