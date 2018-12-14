using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CarMovement : MonoBehaviour
{
    public bool usingVR = false; //Use to change different control mode between NO-VR and VR;

    private GameObject CamVR;//CameraRig.
    private GameObject CamNonVR;//Main camera.

    public SteamVR_Action_Single tempThrottleVR; //Get the input of trigger(float) as the throttle.
    public SteamVR_Action_Boolean BrakeVR; //Get the input of trigger(bool) to reverse.
    public SteamVR_Action_Vector2 rawTempWheelVR;
    private bool Brake; //

    [Range(0.0f, 1000.0f)]
    public float ThrottleCoefficient = 100.0f;
    [Range(0.0f, 100.0f)]
    public float TurningCoefficient = 10.0f;

    private float ThrottleValue; //A float used as the throttle.
    private float WheelValue; //A float used as a control of wheel.

    private WheelCollider WheelFL;
    private WheelCollider WheelFR;
    private WheelCollider WheelBL;
    private WheelCollider WheelBR;

    private void Start()
    {
        WheelFL = GameObject.Find("FLWheel").GetComponent<WheelCollider>();
        WheelFR = GameObject.Find("FRWheel").GetComponent<WheelCollider>();
        WheelBL = GameObject.Find("BLWheel").GetComponent<WheelCollider>();
        WheelBR = GameObject.Find("BRWheel").GetComponent<WheelCollider>();

        CamVR = GameObject.Find("[CameraRig]");
        CamNonVR = GameObject.Find("Main Camera");
        if (usingVR)
        {
            CamVR.SetActive(true);
            CamNonVR.SetActive(false);
        } else
        {
            CamVR.SetActive(false);
            CamNonVR.SetActive(true);
        }
    }

    private void Update()
    {
        UpdateInputValue();
        Throttle();
        Wheel();
    }

    void UpdateInputValue ()
    {
        if (usingVR)
        {
            ThrottleValue = tempThrottleVR.GetAxis(SteamVR_Input_Sources.Any);
            WheelValue = rawTempWheelVR.GetAxis(SteamVR_Input_Sources.Any).x;
            Brake = BrakeVR.GetState(SteamVR_Input_Sources.Any);
            //Input when using VR.
        } else
        {
            ThrottleValue = Input.GetAxis("Vertical");
            if (Input.GetKey(KeyCode.Space))
            {
                Brake = true;
            } else
            {
                Brake = false;
            }
            //Input when not using VR.
            WheelValue = Input.GetAxis("Horizontal");
        }
    }

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

    void Wheel ()
    {
        if (WheelValue != 0)
        {
            WheelFL.steerAngle = WheelValue * TurningCoefficient;
            WheelFR.steerAngle = WheelValue * TurningCoefficient;
        }
    }
}

