using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachGoal : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print("Reached goal!");
    }

    private void OnTriggerStay(Collider other)
    {
        print("Reached goal!");
    }
}
