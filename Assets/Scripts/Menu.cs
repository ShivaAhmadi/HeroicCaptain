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

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartGame() {

        SceneManager.LoadScene("Game");
    }
    public void ExitGame() {

        SceneManager.LoadScene("Game");
    }
}
