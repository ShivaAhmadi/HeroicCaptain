using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game_Contoroller : MonoBehaviour
{
    public Text HighScoreText;
    public Text lastScoreText;
    
    public int totalscore;
    public int highScore;

    public Score_Manager score_manager;

    public GameObject gameOverPanel;
    public GameObject gamePauseButton;
    public GameObject gamePausePanel;

    void Start()
    {
        
    }

    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        totalscore = score_manager.totalScore;

        HighScoreText.text = "High Score: " + highScore.ToString();
        lastScoreText.text = "Your Score: " + totalscore.ToString();
        
    }
    
    public void RestartGame() {

        SceneManager.LoadScene("Game");
    }
    
    public void PauseGame() {
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
        gameOverPanel.SetActive(false);
        gamePauseButton.SetActive(false);

    }

    public void ResumeGame() {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }
     public void BackHomeGame() {
        Time.timeScale = 0;
        gamePausePanel.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
