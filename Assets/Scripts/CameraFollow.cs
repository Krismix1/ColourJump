using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private Vector3 offset = new Vector3(0, 3, -5);
    public Transform target;
    	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = target.position + offset;
	}
}
