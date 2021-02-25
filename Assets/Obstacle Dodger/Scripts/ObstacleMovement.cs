using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float speed = 4f;
    public Transform trans;
    private Vector3 playerPos;
    private Vector3 targetPos;


    void Update()
    {
        playerPos = trans.position;
        targetPos = new Vector3(-5.5f, playerPos.y, playerPos.z);
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (playerPos.x > 5.5f)
        {
            print("Player position is " + playerPos.x);
            float step = 1000;
            transform.position = Vector3.MoveTowards(playerPos, targetPos, step);
        }
    }
}
