using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : Sense
{
    Aspect aspect;

    public override void Initialize()
    {

    }

    public override void UpdateSense()
    {
        if ( aspect!=null && aspect.aType ==targetAspectType)
        {
            Debug.Log(aspect.aType + "  cok yakinininda dikkatli olun");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        aspect = other.transform.GetComponent<Aspect>();
    }


    private void OnTriggerExit(Collider other)
    {
        aspect = null;
    }

}
