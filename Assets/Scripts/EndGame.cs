using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] Text scoreDisplay;
    private int totalScore;
    public float counter = 0.05f;
    float timer = 0f;
    int i = 0;

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("TotalScore");
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (i < totalScore && timer >= counter)
        {
            i++;
            scoreDisplay.text = i.ToString();
            timer = 0f;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
