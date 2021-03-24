using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
   public Transform targert;
   public int speed;
   
   void Update()
   {
       transform.RotateAround(targert.transform.position, targert.transform.up, speed * Time.deltaTime);
   }
}
