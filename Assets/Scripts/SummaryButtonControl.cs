using UnityEngine;
using UnityEngine.SceneManagement;

public class SummaryButtonControl : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitLvl()
    {
        SceneManager.LoadScene("Menu");
    }
}
