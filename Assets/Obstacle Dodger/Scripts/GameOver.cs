using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadNextScene()
    {
        if(PlayerPrefs.GetInt("nextScene") == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (PlayerPrefs.GetInt("nextScene") == 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
