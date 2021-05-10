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

    private void Start()
    {
        PlayerPrefs.SetInt("Lvl1MaxScore", Convert.ToInt32(gemsCount.transform.childCount));
    }
    void FixedUpdate()
    {
        if (player.transform.position.y <= fallingKiller.position.y)
        {
            Invoke("Restart", 1);
        }

        if(player.transform.position.x >= EndOfLevel.position.x)
        {
            PlayerPrefs.SetInt("Lvl1Score", Convert.ToInt32(playerScore.text));
            SceneManager.LoadScene("Lvl1-summary");
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
