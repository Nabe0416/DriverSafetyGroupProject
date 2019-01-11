using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve;

public class movementHandler : MonoBehaviour
{



    public bool notVR = true;
    private GameObject camVR;
    private GameObject camera;


    
    public float movementSpeed;

    // Use this for initialization
    void Start()
    {

    }


    void Movement() {


        if (!Input.GetKey(KeyCode.LeftShift) || !Input.GetKey("w"))
        {
            if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            }
            else if (Input.GetKey("s"))
            {
                transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            }
        }
        else
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;

        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }

    }

    //Update is called once per frame
    private void FixedUpdate()
    {
        if (notVR)
        {
            Movement();
        }
      
    }
}