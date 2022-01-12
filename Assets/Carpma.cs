using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour {

    public int isabet=0;
    public int zarar = 0;

    void OnCollisionEnter(Collision Sphere)
    {
        if (Sphere.gameObject.name == "playerTank")
        {
            isabet=1;
            //Debug.Log("Carpti Playera");
            Sphere.gameObject.GetComponent<TankHealth>().TakeDamage(isabet);
        }
        else if(Sphere.gameObject.name == "EnemyTank")
        {
            zarar=1;
           // Debug.Log("Carpti Dusmana");
            Sphere.gameObject.GetComponent<DusmanHealth>().TakeDamage(zarar);
        }
    }
}
