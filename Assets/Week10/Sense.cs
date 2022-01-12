using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR

using UnityEditor;

#endif

public abstract class Sense : MonoBehaviour, ISenseBehaviour {

    public abstract void Initialize();
    public abstract void UpdateSense();
    protected AspectType targetAspectType = AspectType.ENEMY;

    // Use this for initialization
    void Start () {
        Initialize();

    }
	
	// Update is called once per frame
	void Update () {
        UpdateSense();
    }
}
