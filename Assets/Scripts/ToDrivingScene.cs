using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDrivingScene : MonoBehaviour
{
    public CapsuleCollider player;

    private void OnTriggerEnter(Collider other)
    {
        if(other == player)
        {
            SceneManager.LoadScene("Driving");
        }
    }
}
