using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerKontrol : MonoBehaviour {
	
	public Rigidbody rb;
    public float hiz = 3.0f;

	void Start () {
		rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0f,0.66f,-10f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate (Input.GetAxis("Vertical")*Vector3.forward*hiz*Time.deltaTime);
		transform.Rotate (Input.GetAxis("Horizontal")*Vector3.up*hiz*hiz*hiz*hiz*Time.deltaTime); 
		
    }



}
