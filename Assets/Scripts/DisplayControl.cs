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
    [SerializeField] Text scoreDisplay;
    private int maxScore;
    private int playerScore;
    private int i = 0;
    public float counter = 0.05f;
    float timer = 0f;

    private void Start()
    {
        FullStar1.enabled = false;
        FullStar2.enabled = false;
        FullStar3.enabled = false;
        playerScore = PlayerPrefs.GetInt("LevelScore");
        maxScore = PlayerPrefs.GetInt("MaxScore");
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (i < playerScore && timer >= counter)
        {
            i++;
            scoreDisplay.text = i.ToString();
            timer = 0f;
        }

        if(i >= (maxScore/4))
        {
            EmptyStar1.enabled = false;
            FullStar1.enabled = true;
        }

        if (i >= (maxScore / 2))
        {
            EmptyStar2.enabled = false;
            FullStar2.enabled = true;
        }

        if (i >= (maxScore-1))
        {
            EmptyStar3.enabled = false;
            FullStar3.enabled = true;
        }
    }
}
