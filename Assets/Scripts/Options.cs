using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Options : MonoBehaviour
{
    int timer = 0;
    public TextMeshProUGUI timerText;
    private void Start()
    {
        InvokeRepeating("Timer", 0f , 1f);
    }

    private void Timer()
    {
        timer++;
        timerText.text = (timer / 60).ToString("00") + ":" + (timer % 60).ToString("00");
    }

    public void MainMenu()//function to go to the main menu
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
    public void QuitGame()//function to quit the game
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Restart()//function to restart the game by loading the game scene
    {
        SceneManager.LoadScene("Scenes/Game");
    }    
    
}
