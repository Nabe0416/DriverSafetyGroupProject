using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class tempWalkingSphere : MonoBehaviour {


    public bool usingVR = false;
    public SteamVR_Action_Single tempWalkingVR; //Get the input of trigger(float) as the throttle.
   
    public SteamVR_Action_Vector2 rawTempWheelVR;
 

    [Range(0.0f, 1000.0f)]
    public float walkingSpeed = 100.0f;
    [Range(0.0f, 100.0f)]
    public float TurningCoefficient = 10.0f;

    private float walkingValue;


    private void Start()
    {

    }

    private void Update()
    {
        UpdateInputValue();
        Walking();
      
    }

    void UpdateInputValue()
    {
        if (usingVR)
        {
            //walkingValue = tempWalkingVR.GetAxis(SteamVR_Input_Sources.Touchpad);
          
        }
        else
        {
            walkingValue = Input.GetAxis("Vertical");
           
            walkingValue = Input.GetAxis("Horizontal");
        }
    }

    void Walking()
    {
        if (walkingValue != 0)
        {
            walkingSpeed = walkingValue * Time.deltaTime;
        }

    }

}

