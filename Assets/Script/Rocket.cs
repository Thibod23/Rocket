using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public Rigidbody RocketRigidBody;
    [SerializeField] public float ForceUpward = 2000;
    [SerializeField] public float ForceForward = 2000;
    // Use this for initialization
    void Start () {
        RocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        detecterEspace();
        detecterHorizontal();
	}

    private void detecterHorizontal()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(-ForceForward, 0, 0), new Vector3(0,3,0));
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(ForceForward, 0, 0), new Vector3(0, 3, 0));
        }
    }

    private void detecterEspace()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            RocketRigidBody.AddRelativeForce(new Vector3(0, ForceUpward, 0));
        }
    }
}
