using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum Colours : int {RED = 0, GREEN = 1, BLUE = 2, YELLOW = 3};

    public static int gameSpeedMultiplier = 1;
    //public Text scoreField;


    private int points = 0;

    public void AddPoints(int numberOfPoints)
    {
        Debug.Log(numberOfPoints + " points added");
        points += numberOfPoints;
    }

    public int GetPoints()
    {
        return points;
    }


    /*private void OnGUI()
    {

    }*/
}
