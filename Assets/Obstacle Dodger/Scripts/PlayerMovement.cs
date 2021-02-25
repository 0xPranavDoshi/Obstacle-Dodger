using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject gameOver;
    public Transform trans;


    private void Start()
    {
        transform.position = new Vector3(0, 1, -40);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if(trans.position.y < -3)
        {
            PlayerPrefs.SetInt("nextScene", 0);
            gameOver.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.transform.tag == "Obstacle")
        {
            Debug.Log("Collision Detected!");
            PlayerPrefs.SetInt("nextScene", 0);
            gameOver.SetActive(true);
        }

        if (collisionInfo.transform.tag == "End")
        {
            Debug.Log("Level Complete!");
            PlayerPrefs.SetInt("nextScene", 1);
            gameOver.SetActive(true);
        }
    }
}
