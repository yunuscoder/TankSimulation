using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{

 public float hiz, mesafe;
 public bool yurume, ates;
 public Transform playerTank;
 Vector3 poz;

 void Start () 
 {
  
 }
 

 void Update ()
 {
  poz = new Vector3 (playerTank.position.x, transform.position.y, playerTank.position.z);
  mesafe = Vector3.Distance(transform.position,playerTank.position); 
  if(mesafe < 10)
  {
   yurume = true;
   ates = false;
  
  }
  if(mesafe > 10)
  {
   yurume = false;
   ates = false;

  }
  if (mesafe < 5)
  {
   yurume = false;
   ates = true;
    }
 
  if (yurume)
  {
   hiz = 3;
   transform.position = Vector3.MoveTowards(transform.position, playerTank.position, hiz * Time.deltaTime);
   transform.LookAt (poz); 
   //GetComponent<Animation>().Play("Run");
          }
  if (ates) { 
   transform.LookAt (poz);
   //GetComponent<Animation>().Play("StandingFire");
  }
  if(yurume == false && ates == false) {
   //GetComponent<Animation>().Play("Idle");
 }
}
}