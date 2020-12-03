using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void PlayGame()//function to show the game scene
    {
        SceneManager.LoadScene("Scenes/Game");
    }

    public void Rules()//function to show the rules scene
    {
        SceneManager.LoadScene("Scenes/Rules");
    }

    public void QuitGame()//function to quit the game
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
