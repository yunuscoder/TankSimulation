using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankAI : MonoBehaviour {

    public Transform playerTank;
    public Transform[] waypointsTransform;
    Vector3[] waypoints;
    int currentIndex = 0;

    Animator fsmAI;
    float maxCheckDistance=10;
    NavMeshAgent agent;
    

	// Use this for initialization
	void Start () {
        fsmAI = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        waypoints = new Vector3[4];
        waypoints[0] = waypointsTransform[0].position;
        waypoints[1] = waypointsTransform[1].position;
		waypoints[2] = waypointsTransform[2].position;
		waypoints[3] = waypointsTransform[3].position;
        agent.SetDestination(waypoints[currentIndex]);
    }

    internal void SetNewWayPoint()
    {
        switch (currentIndex)
        {
            case 0:
                currentIndex = 1;
                break;
            case 1:
                currentIndex = 2;
                break;
			case 2:
                currentIndex = 3;
                break;
			case 3:
                currentIndex = 0;
                break;
        }
        agent.SetDestination(waypoints[currentIndex]);
    }

    // Update is called once per frame
    void FixedUpdate () {
        float distance = Vector3.Distance(playerTank.position, transform.position);//(player.position - transform.position).magnitude;
        fsmAI.SetFloat("distance", distance);

        float disFromWayPoint = Vector3.Distance(transform.position, waypoints[currentIndex]);
        fsmAI.SetFloat("distanceFromWayPoint", disFromWayPoint);

        Vector3 dir = (playerTank.position - transform.position).normalized;  // birim vektor olacak.
        Ray ray = new Ray(transform.position, dir);
        Debug.DrawRay(ray.origin, ray.direction * maxCheckDistance);
        //RaycastHit hitInfo;

        if (Physics.Raycast(ray.origin,ray.direction, maxCheckDistance))
        {
            fsmAI.SetBool("isVisible", true);
        }
        else
            fsmAI.SetBool("isVisible", false);





    }

    public void Patrol()
    {
        Debug.Log("patrolling");
    }

    public void Follow()
    {
        Debug.Log("Following");
    }

    public void Shoot()
    {
        Debug.Log("Shooting");
    }






}
