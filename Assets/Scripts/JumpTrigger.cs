using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player") // Make sure is the Players who triggers
        {
            other.GetComponent<PlayerController>().Jump(); 
        }
    }
}
