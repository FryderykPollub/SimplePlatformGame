using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int healthValue = 3;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.SetInt("Health", healthValue);
    }

    public void HardMode(bool value)
    {
        if (value) healthValue = 1;
        else healthValue = 3;
    }

    public void ExitGame()
    {
        Debug.Log("Exiting the game");
        Application.Quit();
    }
}
