using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnAccelerator : MonoBehaviour
{
    public GameObject accelerator;
    public GameObject plane;
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (var i = 0; i < 5; i++)
        {
            Debug.Log(i);
            var randomX = Random.Range(-8, 8); 
            var randomZ = Random.Range(-45, 35); 
            var randomPosition = new Vector3(randomX, 0, randomZ);
            Instantiate(accelerator, randomPosition, Quaternion.identity);
        }
    }
}
