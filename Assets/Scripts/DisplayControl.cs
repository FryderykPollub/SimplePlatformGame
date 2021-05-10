using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayControl : MonoBehaviour
{
    [SerializeField] Image FullStar1;
    [SerializeField] Image FullStar2;
    [SerializeField] Image FullStar3;
    [SerializeField] Image EmptyStar1;
    [SerializeField] Image EmptyStar2;
    [SerializeField] Image EmptyStar3;
    
    public Text scoreDisplay;
    private int maxScore;
    private int playerScore;
    int i = 0;

    private void Start()
    {
        FullStar1.enabled = false;
        FullStar2.enabled = false;
        FullStar3.enabled = false;
        playerScore = PlayerPrefs.GetInt("Lvl1Score");
        maxScore = PlayerPrefs.GetInt("Lvl1MaxScore");
    }

    private void Update()
    {
        Invoke("counting", 2f);
    }

    void counting()
    {
        while (i <= playerScore)
        {
            //Invoke(scoreDisplay.text = i.ToString(), 1f);
            scoreDisplay.text = i.ToString();
            if (i >= 1)
            {
                FullStar1.enabled = true;
                EmptyStar1.enabled = false;
            }

            if (i >= (maxScore / 2))
            {
                FullStar2.enabled = true;
                EmptyStar2.enabled = false;
            }

            if (i == maxScore)
            {
                FullStar3.enabled = true;
                EmptyStar3.enabled = false;
            }
            i++;
        }
    }
}
