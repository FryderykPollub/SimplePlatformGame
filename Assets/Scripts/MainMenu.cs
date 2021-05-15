using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int healthValue = 3;

    public void PlayGame()
    {
        PlayerPrefs.SetInt("TotalScore", 0);
        PlayerPrefs.SetInt("Health", healthValue);
        SceneManager.LoadScene("Level1");
    }

    public void HardMode(bool isHardMode)
    {
        if (isHardMode) healthValue = 1;
        else healthValue = 3;
    }

    public void ExitGame()
    {
        Debug.Log("Exiting the game");
        Application.Quit();
    }
}
