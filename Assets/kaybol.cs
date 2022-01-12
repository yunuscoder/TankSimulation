using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaybol : MonoBehaviour {

	float zaman = 0.8f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		zaman-=Time.deltaTime;
		if(zaman<=0)
			Destroy(gameObject);
		
	}
}
