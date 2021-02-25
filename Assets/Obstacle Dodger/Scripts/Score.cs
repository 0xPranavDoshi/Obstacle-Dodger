using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject player;
    public Text text;

    private float score = 0;
    private Vector3 playerPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        playerPosition = player.transform.position;
        score = playerPosition.z + 40;
        text.text = score.ToString("0"); 
    }
}
