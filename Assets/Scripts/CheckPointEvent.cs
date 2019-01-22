using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CheckPointEvent : MonoBehaviour
{
    public GameObject carPrefab;
    public List<Transform> spawnPoint = new List<Transform>();
    public List<GameObject> carList = new List<GameObject>();
    public Transform destroyPoint;

    public static CheckPointEvent instance;

    private int carAmount;

    private void Awake()
    {
        carAmount = spawnPoint.Count;
        instance = this;
    }

    public void InstantiateCars()
    {
        for(int i = 0; i < carAmount; i++)
        {
            GameObject car;
            car = Instantiate(carPrefab);
            car.transform.position = spawnPoint[i].position;
            car.GetComponent<NavMeshAgent>().SetDestination(destroyPoint.position);
            carList.Add(car);
        }
    }

    void CrashPlayer()
    {

    }
}
