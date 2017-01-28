using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public GameObject player;
    public Transform spawnPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player"){

            player = col.transform.gameObject;
            player.transform.position = spawnPoint.transform.position;

        }
    }
}