using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTrigger : MonoBehaviour {

    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(!isTriggered)
        {
            isTriggered = true;
            CheckPointEvent.instance.InstantiateCars();
            print("1");
        }
    }
}
