using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTrigger : MonoBehaviour {

    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 11)
        {
            if (!isTriggered)
            {
                isTriggered = true;
                CheckPointEvent.instance.InstantiateCars();
            }
        }
    }
}
