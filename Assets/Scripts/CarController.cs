using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        // Check for input and set the move direction accordingly
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward; // Move forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back; // Move backward
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left; // Move left
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right; // Move right
        }

        // Apply the movement
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
