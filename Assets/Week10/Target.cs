using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            GoToPoint();
    }

    private void GoToPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       // Debug.DrawRay(ray.origin, ray.direction * 1000);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            transform.position = hitInfo.point; //new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z);

            //transform.position = Vector3.Lerp(transform.position, hitInfo.point, 5 * Time.deltaTime);
        }
    }
}
