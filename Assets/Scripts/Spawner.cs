using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefab;
    public float spawnDelay = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0.1f, spawnDelay);
    }

    void SpawnObject()
    {
        GameObject go = GameObject.Instantiate(prefab, transform.position, Quaternion.identity, transform);
    }
}
