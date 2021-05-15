using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform fallingKiller;
    [SerializeField] private Transform EndOfLevel;
    [SerializeField] private Text playerScore;
    [SerializeField] private GameObject gemsCount;
    private int totalScore;

    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("TotalScore");
        PlayerPrefs.SetInt("MaxScore", Convert.ToInt32(gemsCount.transform.childCount));
        PlayerPrefs.SetInt("CurrentLevel", Convert.ToInt32(SceneManager.GetActiveScene().buildIndex));
    }
    void FixedUpdate()
    {
        if (player.transform.position.y <= fallingKiller.position.y)
        {
            Invoke("Restart", 0.3f);
        }

        if(player.transform.position.x >= EndOfLevel.position.x)
        {
            PlayerPrefs.SetInt("LevelScore", Convert.ToInt32(playerScore.text));
            totalScore += PlayerPrefs.GetInt("LevelScore");
            PlayerPrefs.SetInt("TotalScore", totalScore);
            SceneManager.LoadScene("LevelSummary");
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}