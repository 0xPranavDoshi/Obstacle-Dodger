using UnityEngine;
using UnityEngine.UI;

public class GameCompleteText : MonoBehaviour
{
    public Text text;

    void Update()
    {
        if(PlayerPrefs.GetInt("nextScene") == 1)
        {
            text.text = "Level Complete!";
        }

        else if (PlayerPrefs.GetInt("nextScene") == 0)
        {
            text.text = "Game Over!";
        }
    }
}
