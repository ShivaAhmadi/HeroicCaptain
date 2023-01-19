using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject HelpButton;
    public GameObject ExitButton;
    public GameObject VideoPanel;

    void Start()
    {
        VideoPanel.SetActive(false);
        
    }

    void Update()
    {
        
    }

    public void StartGame() {

        SceneManager.LoadScene("Game");
    }
    public void ExitGame() {

        Application.Quit();
    }
    public void PlayVideo() {
        VideoPanel.SetActive(true);
    }
    public void BackToMenu() {
        VideoPanel.SetActive(false);
    }
}
