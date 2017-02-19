using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour {

    public int points = 100;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().addPoints(points);
            Destroy(gameObject);
        }
    }
}
