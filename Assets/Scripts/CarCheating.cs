using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarCheating : MonoBehaviour
{
    private Transform player;
    private Vector3 des;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnBecameInvisible()
    {
        this.GetComponent<NavMeshAgent>().enabled = false;
        StartCoroutine("moveTowardPlayer");
    }

    private void OnBecameVisible()
    {
        StopCoroutine("moveTowardPlayer");
        this.GetComponent<NavMeshAgent>().enabled = true;
    }

    IEnumerator moveTowardPlayer()
    {
        this.transform.LookAt(player);
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2000 * Time.deltaTime);
        yield return null;
    }
}
