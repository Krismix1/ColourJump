using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public enum Colours : int {RED = 0, GREEN = 1, BLUE = 2, YELLOW = 3};

    public GameObject player;
    public Text scoreField;
    public Text scoreLabel;
    public Text gameOverLabel;
    public Text gameOverScore;
    public Text returnText;
    public AudioSource gameOverAudio;

    private float gameSpeedMultiplier = 1;
    private bool deathShowed = false;

    private void Update()
    {
        if(player.GetComponent<PlayerController>().health <= 0)
        {
            EndGame();
        }
        IncreaseGameSpeed();
        if(player.transform.position.y <= -1.5f) // If the player object fell
        {
            EndGame();
        }
    }

    void EndGame()
    {
        if (deathShowed == false)
        {
            DisplayGameOver();
            gameOverAudio.Play();
            //AudioSource.PlayClipAtPoint(gameOverAudio.clip, Vector3.zero);
            Time.timeScale = 0f;
            deathShowed = true;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(0);
        }
    }

    private void DisplayGameOver()
    {
        gameOverLabel.gameObject.SetActive(true);
        gameOverScore.gameObject.SetActive(true);
        returnText.gameObject.SetActive(true);
        scoreLabel.gameObject.SetActive(false);
        scoreField.gameObject.SetActive(false);
        gameOverScore.text = GetComponent<ScoreManager>().GetScore().ToString();
    }

    private void IncreaseGameSpeed()
    {
        if (GetComponent<ScoreManager>().GetScore() > 3000 * gameSpeedMultiplier)
        {
            gameSpeedMultiplier = gameSpeedMultiplier * 1.15f; // At high speed the ball will fall
            Time.timeScale = gameSpeedMultiplier;
        }
    }
}
