using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : Sense {
    
    float fiealdOfView;
   // float viewDistance;
    public Transform playerTank;
    public Transform rayOrigin;
	public float hiz, mesafe;
	public bool yurume, ates;
	public GameObject prefab;
    public Transform namlu;
    float elapsedTime;
    float nextShoot = 0;

    Vector3 poz;

    public override void Initialize()
    {
        fiealdOfView = 50f;
        //viewDistance = 10f;
    }

    public override void UpdateSense()
    {
        Vector3 dir = (playerTank.position - transform.position).normalized;
        //dir /= dir.magnitude;

        if (Vector3.Angle(dir, transform.forward) < fiealdOfView /2f)
        {
            //RaycastHit hitInfo;
            

			poz = new Vector3 (playerTank.position.x, transform.position.y, playerTank.position.z);
			mesafe = Vector3.Distance(transform.position,playerTank.position); 
			  if(mesafe < 15)
			  {
			   yurume = true;
			   ates = false;
  
			  }
			  if(mesafe > 15)
			  {
			   yurume = false;
			   ates = false;

			  }
			  if (mesafe < 10)
			  {
			   yurume = false;
			   ates = true;
				}
 
			  if (yurume)
			  {
			   hiz = 2;
			   transform.position = Vector3.MoveTowards(transform.position, playerTank.position, hiz * Time.deltaTime);
			   transform.LookAt (poz); 
			   //GetComponent<Animator>().Play("Run");
				 }
			  if (ates) { 
			   transform.LookAt (poz);

                //InvokeRepeating("fonk", 0, 10.0f);

                elapsedTime = Time.time;

                if (elapsedTime > nextShoot)
                {
                    GameObject go = Instantiate(prefab, namlu.position, namlu.rotation);
                    Rigidbody rb = go.GetComponent<Rigidbody>();
                    //rb.velocity = transform.forward * hiz *hiz *hiz *hiz *hiz * Time.deltaTime;
                    rb.AddForce(transform.forward * 1000);
                    nextShoot = elapsedTime + 2.0f;
                }


                //GetComponent<Animator>().Play("StandingFire");
            }
			  if(yurume == false && ates == false) {
			  // GetComponent<Animator>().Play("Idle");
			 }
		}


     }
	//void fonk()
	//{
	//	
	//	GameObject go = Instantiate(prefab, namlu.position, namlu.rotation);
	//	Rigidbody rb = go.GetComponent<Rigidbody>();
	//	rb.AddForce(transform.forward * 10000);
	//}
    }

