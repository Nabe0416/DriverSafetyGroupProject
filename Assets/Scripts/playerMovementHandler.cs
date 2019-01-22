using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class playerMovementHandler : MonoBehaviour {

    public SteamVR_Action_Vector2 touchPad;

    [SerializeField]
    public float moveSpeed = 5.0f;
    [SerializeField]
    public float rotateSpeed = 5.0f;

    private Rigidbody rb;

    private void Awake()
    {
    }


    // Use this for initialization
    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	void Update () {
		
	}

    private void FixedUpdate()
    {
        playerMovement();
    }

    void playerMovement()
    {
        float turning;
        float walking;
        Vector2 input = touchPad.GetAxis(SteamVR_Input_Sources.Any);
        turning = input.x;
        walking = input.y;



        rb.MovePosition(rb.transform.position + transform.forward * Time.deltaTime * moveSpeed * walking);
        Quaternion rotation = Quaternion.Euler(new Vector3(0, turning * rotateSpeed * Time.deltaTime, 0) * Time.deltaTime);
        rb.MoveRotation(rb.transform.rotation * rotation);
    }
}
