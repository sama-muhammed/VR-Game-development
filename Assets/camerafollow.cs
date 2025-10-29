using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The avatar's transform
    public Vector3 offset = new Vector3(0, 2, -5); // Camera offset from the avatar
    public float smoothSpeed = 0.125f; // How smoothly the camera follows the avatar

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("CameraFollow: No target assigned.");
            return;
        }

        // Calculate the desired camera position
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Make the camera look at the avatar
        transform.LookAt(target);
    }
}