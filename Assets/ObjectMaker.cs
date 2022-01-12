using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour {

   
    public GameObject prefab;
    public Transform namlu;
    
	// Use this for initialization
	void Start () {

	}


	void Update () {

        //float x = Random.Range(-5f, 5f);
        //float z = Random.Range(-5f, 5f);
        //Instantiate(prefab, new Vector3(x,0,z), Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(prefab, namlu.position, namlu.rotation);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 1000);

            

        }
	}


    
}
