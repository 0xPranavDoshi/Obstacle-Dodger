using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody rb;
    private float jumpForce = 250f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
