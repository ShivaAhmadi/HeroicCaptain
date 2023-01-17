using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Manager : MonoBehaviour
{
    public int totalScore = 0;
    public int foodScore=10;
    public int highScore;
    public static int lastScore = 0;

    public Text TotalscoreText;
    public Text FoodscoreText;
    public Text HighScoreText;
    public Text lastScoreText;

    void Start()
    {
        StartCoroutine(Score());
        highScore = PlayerPrefs.GetInt("high_score" , 0);
        //HighScoreText.text = "High Score: " + highScore.ToString();
        //lastScoreText.text = "Last Score: " + lastScore.ToString();
        
    }

    void Update()
    {
        TotalscoreText.text = totalScore.ToString();
        FoodscoreText.text = foodScore.ToString();
        if (totalScore > highScore) {
            highScore = totalScore;
            PlayerPrefs.SetInt("high_score", highScore);
        
        }
        
    }
    IEnumerator Score() {
        while(true){
            yield return new WaitForSeconds(2);
            totalScore = totalScore + 1;
            foodScore=foodScore-1;
            lastScore = totalScore;
        }
    }
    IEnumerator Reload() {
      
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Game");

    }
    
}
