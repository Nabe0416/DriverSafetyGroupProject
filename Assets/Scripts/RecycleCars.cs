using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RecycleCars : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DestinationTag tag = other.GetComponent<DestinationTag>();
        if (tag != null)
        {
            this.gameObject.SetActive(false);
        }
    }
}
