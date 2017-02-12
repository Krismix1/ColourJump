using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    public float zVel = 10f;

    private Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
        pos += Vector3.back * zVel * Time.deltaTime;
        transform.position = pos;
	}
}
