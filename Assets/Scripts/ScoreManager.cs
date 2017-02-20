using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	#region Public Fields
	public int pointsByTime = 50;
    public int secondsToGivePoints = 2;
    public Text ScoreText;
    #endregion

    #region Private Fields
    private int score;
    #endregion

    #region Functions

    public void AddScore(int points)
    {
        score += points;
    }

    public int GetScore()
    {
        return score;
    }

    void Start()
    {
        score = 0;
        InvokeRepeating("AddScoreByTime", 0, secondsToGivePoints);
    }

    void AddScoreByTime()
    {
        AddScore(pointsByTime);
    }

    void OnGUI()
    {
        ScoreText.text = GetScore().ToString();
    }
	
	#endregion
}
