using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager;

    private int score = 0;
    private int lives = 1;
    private int highScore = 0;

    public Text Txt_Score;
    public Text Txt_Highscores;
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;

        highScore = PlayerPrefs.GetInt("HighScore");
        Txt_Highscores.text = "Highscore : " + highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        Txt_Score.text = "Score : " + score;
    }

    public void GameOver()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        SceneManager.LoadScene("GameLose");
    }

    public void UpdateLives()
    {
        lives--;

        if (lives <= 0)
        {
            GameOver();
        }
    }
}
