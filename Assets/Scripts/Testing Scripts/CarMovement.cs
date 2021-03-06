﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CarMovement : MonoBehaviour
{
    public bool usingVR = false; //Use to change different control mode between NO-VR and VR;


    //public SteamVR_Action_Single tempThrottleVR; //Get the input of trigger(float) as the throttle.
    //public SteamVR_Action_Boolean BrakeVR; //Get the input of trigger(bool) to reverse.
    public SteamVR_Action_Vector2 rawTempWheelVR;
    //private bool Brake; //

        /**
    [Range(0.0f, 1000.0f)]
    public float ThrottleCoefficient = 100.0f;
        **/
    [Range(0.0f, 100.0f)]
    public float TurningCoefficient = 10.0f;
    /**
    private float ThrottleValue; //A float used as the throttle.
        **/
    private float WheelValue; //A float used as a control of wheel.
        
    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelBL;
    public WheelCollider WheelBR;

    private void Awake()
    {

    }

    private void Start()
    {

    }

    void Update()
    {
        UpdateInputValue();
        Throttle();
        Wheel();
        Debug.Log(WheelValue);
    }

    void UpdateInputValue ()
    {
        if (usingVR)
        {
            //ThrottleValue = tempThrottleVR.GetAxis(SteamVR_Input_Sources.Any);
            WheelValue = rawTempWheelVR.GetAxis(SteamVR_Input_Sources.Any).x;
            
            //Brake = BrakeVR.GetState(SteamVR_Input_Sources.Any);
            //Input when using VR.
        } else
        {
            /**
            ThrottleValue = Input.GetAxis("Vertical");
            if (Input.GetKey(KeyCode.Space))
            {
                Brake = true;
            } else
            {
                Brake = false;
            }
            //Input when not using VR.
            **/
            WheelValue = Input.GetAxis("Horizontal");
        }
    }
    /**
    void Throttle ()
    {
        if (ThrottleValue != 0)
        {
            WheelBL.motorTorque = ThrottleValue * ThrottleCoefficient;
            WheelBR.motorTorque = ThrottleValue * ThrottleCoefficient;
        }
        if (Brake)
        {
            WheelBL.brakeTorque = 100.0f;
            WheelBR.brakeTorque = 100.0f;
        } else
        {
            WheelBL.brakeTorque = 0.0f;
            WheelBR.brakeTorque = 0.0f;
        }
    }
    **/

    void Throttle()
    {
        WheelBL.motorTorque = 750.0f;
        WheelBR.motorTorque = 750.0f;
    }

    void Wheel ()
    {
        if (WheelValue != 0 && WheelValue < 0.4f && WheelValue > -0.4f)
        {
            WheelFL.steerAngle = WheelValue * TurningCoefficient;
            WheelFR.steerAngle = WheelValue * TurningCoefficient;
        }
    }
}

