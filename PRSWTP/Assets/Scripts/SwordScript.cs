﻿using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

    public bool drawn;
    //True for sword-out
    //False for sword-down

    private Transform ts;

	// Use this for initialization
	void Start () {
        ts = GetComponent<Transform>();

        if (drawn) { swordUp(); }
        else { swordDown(); }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void toggleSword()
    {
        drawn = !drawn;

        if (drawn) { swordUp(); }
        else { swordDown(); }
    }

    void swordUp ()
    {
        ts.position.Set(1.8f, 0.15f, 0);
        Quaternion newRot = Quaternion.Euler(0, 0, -85);
        ts.rotation.Set(newRot.x, newRot.y, newRot.z, newRot.w);
        ts.localScale.Set(0.15f, 0.6f, 0.3f);
    }

    void swordDown()
    {
        ts.position.Set(0.2f, -0.175f, -0.7f);
        Quaternion newRot = Quaternion.Euler(0, 0, 5);
        ts.rotation.Set(newRot.x, newRot.y, newRot.z, newRot.w);
        ts.localScale.Set(0.3f, 0.3f, 0.3f);
    }
}
