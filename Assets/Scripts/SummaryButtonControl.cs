using UnityEngine;
using UnityEngine.SceneManagement;

public class SummaryButtonControl : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel")+1);
    }

    public void Retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel"));
    }

    public void ExitLvl()
    {
        SceneManager.LoadScene("Menu");
    }
}
