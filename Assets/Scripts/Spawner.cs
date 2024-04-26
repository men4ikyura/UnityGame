using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class CubeSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] spawnObjects;
    public float timeSpawn;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
       while(true)
       {
           yield return new WaitForSeconds(timeSpawn);
            var choiceSpawn = Random.Range(0, spawnPoint.Length);
            var currentSpawner = spawnPoint[choiceSpawn];
            var spawnArea = currentSpawner.position + new Vector3(0,0, Random.Range(-16, 18));
            Instantiate(spawnObjects[choiceSpawn], spawnArea, currentSpawner.rotation);
       } 
    }
}
