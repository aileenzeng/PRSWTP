﻿using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class BulletScript : MonoBehaviour {


    public float speed;
    private double time;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<AudioSource>().Play();
        Debug.Log("play");
        time += Time.deltaTime;
        //despawn timer
        if (time > 4f)
        {
            kill();
        }
        getTime();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            kill();
        }
        if (col.gameObject.layer == 8) //ground layer
        {
            kill();
        }
        if (col.gameObject.tag == "SecretWall")
        {
            Destroy(col.gameObject);
            kill();
        }
    }

    void kill()
    {
        Destroy(this.gameObject);
    }

	public int getTime() 
	{
		int time2 = (int)(time * 10);
        //Debug.Log("Gun Time: " + (4 - time2));
        return time2;
	}
}
