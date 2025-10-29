using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2f; // Movement speed
    public float rotationSpeed = 10f; // Rotation speed for smoother turning
    public Transform leftShoulder; // Reference to the left shoulder bone/transform
    public Transform rightShoulder; // Reference to the right shoulder bone/transform
    public Transform leftFoot; // Reference to the left foot bone/transform
    public Transform rightFoot; // Reference to the right foot bone/transform
    public Vector3 armsDownRotation = new Vector3(0, 0, -90); // Rotation to keep arms down
    public float footMovementRange = 0.2f; // Range of foot movement
    public float footMovementSpeed = 5f; // Speed of foot movement
    public float playerRadius = 0.6f; // Distance to check for collisions

    private bool isColliding = false; // Track if the avatar is colliding
    private float footMovementTimer = 0f; // Timer to synchronize foot movement

    void Update()
    {
        // Get input from the player
        float vertical = Input.GetAxis("Vertical"); // Forward and backward movement
        float horizontal = Input.GetAxis("Horizontal"); // Left and right movement

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Check for collisions
        isColliding = CheckCollision(moveDirection);

        // Move the character if there's no collision
        if (moveDirection.magnitude > 0.5f && !isColliding)
        {
            MoveCharacter(moveDirection);
            MoveFeet(); // Move feet in sync with movement
        }
        else
        {
            ResetFeet(); // Reset feet to default position when not moving
        }

        // Rotate the character to face the movement direction
        RotateCharacter(moveDirection);

        // Keep arms down
        KeepArmsDown();
    }

    void MoveCharacter(Vector3 direction)
    {
        // Move the character forward/backward
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    void KeepArmsDown()
    {
        // Adjust the rotation of the shoulders to keep the arms down
        if (leftShoulder != null)
        {
            leftShoulder.localEulerAngles = armsDownRotation;
        }

        if (rightShoulder != null)
        {
            rightShoulder.localEulerAngles = new Vector3(armsDownRotation.x, armsDownRotation.y, -armsDownRotation.z); // Mirror for right shoulder
        }
    }

    void RotateCharacter(Vector3 direction)
    {
        // Smoothly rotate the character to face the movement direction
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    bool CheckCollision(Vector3 direction)
    {
        // Perform a raycast in the movement direction
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, playerRadius))
        {
            // If an obstacle is detected, log the collider name and return true
            Debug.Log("Collision detected with: " + hit.collider.name);
            Debug.DrawRay(transform.position, direction * playerRadius, Color.red); // Visualize the raycast
            return true;
        }
        else
        {
            Debug.DrawRay(transform.position, direction * playerRadius, Color.green); // Visualize the raycast
        }

        // No collision detected
        Debug.Log("No collision detected.");
        return false;
    }

    void MoveFeet()
    {
        // Increment the timer for foot movement
        footMovementTimer += Time.deltaTime * footMovementSpeed;

        // Calculate foot movement using a sine wave for smooth oscillation
        float footOffset = Mathf.Sin(footMovementTimer) * footMovementRange;

        // Apply movement to the feet
        if (leftFoot != null)
        {
            leftFoot.localPosition = new Vector3(leftFoot.localPosition.x, footOffset, leftFoot.localPosition.z);
        }

        if (rightFoot != null)
        {
            rightFoot.localPosition = new Vector3(rightFoot.localPosition.x, -footOffset, rightFoot.localPosition.z);
        }
    }

    void ResetFeet()
    {
        // Reset feet to their default position when not moving
        if (leftFoot != null)
        {
            leftFoot.localPosition = new Vector3(leftFoot.localPosition.x, 0, leftFoot.localPosition.z);
        }

        if (rightFoot != null)
        {
            rightFoot.localPosition = new Vector3(rightFoot.localPosition.x, 0, rightFoot.localPosition.z);
        }

        // Reset the foot movement timer
        footMovementTimer = 0f;
    }
}
