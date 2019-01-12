using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateOutput : MonoBehaviour {

    /**public float totalRotation = 0.0f;

    private float previousRotation = 0.0f;**/

    /**public float current = 0.0f;
    public float previous = 0.0f;
    public float total = 0.0f;**/

    public Vector3 eulerAng;

    private int Quadrant;
    private float value;
    private float result;

    private void Start()
    {
        /**Vector3 a = Vector3.up;
        Vector3 b = transform.TransformDirection(transform.up);
        //float result = Mathf.Asin(Vector3.Distance(Vector3.zero, Vector3.Cross(a.normalized, b.normalized))) * Mathf.Rad2Deg;
        float currentRotation = Vector3.Angle(a, b);
        previousRotation = currentRotation;**/
    }

    // Update is called once per frame
    void Update () {
        GameObject.Find("Text").GetComponent<Text>().text = UpdateValue().ToString();
	}

    private float UpdateValue()
    {
        /**
        //Vector3 parent = GameObject.Find("Steering Wheel").;
        Vector3 a = Vector3.up;
        Vector3 b = transform.TransformDirection(transform.up);
        current= Mathf.Asin(Vector3.Distance(Vector3.zero, Vector3.Cross(a.normalized, b.normalized))) * Mathf.Rad2Deg;
        total += (previous - current);
        previous = current;
        float currentRotation = Vector3.Angle(a, b);

        totalRotation += (previousRotation - currentRotation);
        previousRotation = currentRotation;

        //float angle = 0.0f;
        //angle = transform.localRotation.eulerAngles.y;

        return totalRotation;**/

        /**
        float currentAngle = this.transform.rotation.eulerAngles.x;
        float previousAngle = currentAngle;**/

        eulerAng = this.transform.rotation.eulerAngles;

        if (eulerAng.y == 270 && eulerAng.z == 90 && eulerAng.x != 0 && eulerAng.x != 90)
        {
            if (eulerAng.x > 0)
            {
                value = eulerAng.x;
            }
            else
            {
                value = eulerAng.x;

            }
        }
        else if (eulerAng.y == 270 && eulerAng.z == 90 && eulerAng.x == 0)
        {
            value = 0;
        }
        else if (eulerAng.x == 90)
        {
            value = 90;
        }
        else
        {
            if (eulerAng.x < 90)
            {
                value = 180 - eulerAng.x;
            }
            else
            {
                value = 540 - eulerAng.x;
            }
        }

        float preValue = value;
        if (value >= preValue)
        {
            result = value;
        }
        else
        {
            result = -value;
        }

        

        //print(eulerAng);
        return result;
        
    }
}
