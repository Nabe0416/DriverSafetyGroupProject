using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Interactable : MonoBehaviour {

    private GameObject collidingObj;
    private GameObject linkedObj;

    private bool isLinked = false;
    public SteamVR_Action_Boolean triggerButton;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        GrabbingAndReleasing();
    }

    private void OnTriggerEnter(Collider other)
    {
        collidingObj = other.gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        collidingObj = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        collidingObj = null;
    }

    void GrabbingAndReleasing()
    {
        bool trigger = triggerButton.GetStateDown(SteamVR_Input_Sources.Any);//Get the state of both two triggers.
        if (trigger == true)//If one trigger is down
        {
            if (collidingObj != null && linkedObj == null)//if there is anything colliding with the collider of the game obj which this code is attached on AND there is no linked obj
            {
                //Create fixed joint and connect two objs
                FixedJoint joint;
                Rigidbody rb = this.GetComponent<Rigidbody>();

                joint = this.gameObject.AddComponent<FixedJoint>();
                joint.connectedBody = collidingObj.GetComponent<Rigidbody>();

                linkedObj = collidingObj;
                isLinked = true;
                print("Linked!!");
            }
            //if there is a linked obj, release it
            if (linkedObj != null)
            {
                this.GetComponent<FixedJoint>().connectedBody = null;
                Destroy(this.GetComponent<FixedJoint>());

                linkedObj = null;
                isLinked = false;
                print("Unlinked");
            }
        }

    }
}
