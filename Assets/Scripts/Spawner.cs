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
        GameObject go = Instantiate(prefab, transform.position, Quaternion.identity, transform);
        //ChangeColour colourManager = go.GetComponent<ChangeColour>();
        //int colourID = Random.Range(0, 4);
        //colourManager.ChangeColor(go.GetComponent<Renderer>(), colourID);
    }
    
}
