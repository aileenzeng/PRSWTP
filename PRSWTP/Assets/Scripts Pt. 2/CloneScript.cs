﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script is intended to represent all the past selves
 * in order to differentiate current/past selves from each
 * other. More betterer.
 * 
 * It might not work. Sorry :(
 * It definitely doesn't work.s
*/

public class CloneScript : MonoBehaviour {
    private float gameTicks;
    public bool isDead;
    private Vector3 cloneLoc;

    // Use this for initialization
    void Start () {
        isDead = false;

	}
	
	// Update is called once per frame
	void Update () {

	}

    public void setRotation()
    {
        //insert math here that calculates differences
        //in x values from setPosition :)
    }

    //taken from PlayerScript - sets position of the clone
    public void setPosition(Vector3 vector)
    {
        cloneLoc = vector;
        var marker = TrackMovement.MARKER;

        transform.position = vector;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //PlayerScript.GetComponent<PlayerScript>().health--;
            Debug.Log("You colllided with your past self!!");
        }
    }

}
