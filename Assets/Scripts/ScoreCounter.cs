using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void counter()
    {
        score++;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
