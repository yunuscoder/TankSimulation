using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoBehaviour {

    float movementAxis, turnAxis;
    public float moveSpeed, turnSpeed;
    public Transform targetPoint;
	// Use this for initialization
	void Start () {
       // moveSpeed = 10f;
        //turnSpeed = 120f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(targetPoint.position, transform.position) > 2)
            GoToTargetPoint();
        
        //TankControlByKeyWord();
    }

    private void GoToTargetPoint()
    {
        Vector3 dir = (targetPoint.position - transform.position).normalized;
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);
    }

    private void TankControlByKeyWord()
    {
        movementAxis = Input.GetAxisRaw("Vertical");
        turnAxis = Input.GetAxisRaw("Horizontal");

        transform.position += transform.forward * movementAxis * moveSpeed * Time.deltaTime;
        Vector3 turnVector = new Vector3(0, 1, 0) * turnAxis * turnSpeed * Time.deltaTime;
        transform.Rotate(turnVector);
    }
}
