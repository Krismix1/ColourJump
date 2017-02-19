using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum Colours : int {RED = 0, GREEN = 1, BLUE = 2, YELLOW = 3};

    public static int gameSpeedMultiplier = 1;


    private int points = 0;

    public void addPoints(int numberOfPoints)
    {
        Debug.Log(numberOfPoints + " points added");
        points += numberOfPoints;
    }

    public int getPoints()
    {
        return points;
    }
    

}
