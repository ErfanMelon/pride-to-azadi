using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The car to follow
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the car
    public float smoothSpeed = 0.125f; // Smoothing factor

    void LateUpdate()
    {
        // Desired position based on the target position and offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply the smoothed position to the camera
        transform.position = smoothedPosition;

        // Optionally, make the camera look at the car
        transform.LookAt(target);
    }
}
