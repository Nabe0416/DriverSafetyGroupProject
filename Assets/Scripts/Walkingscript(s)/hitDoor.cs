using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDoor : MonoBehaviour {
 
    private void OnTriggerEnter(Collider other)
    {
        print("Opened door!");
    }

    private void OnTriggerStay(Collider other)
    {
        print("Opened door!");
    }
}
