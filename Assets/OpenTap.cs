using UnityEngine;

public class OpenTap : MonoBehaviour
{
    public Transform tapHandle; // Assign the tap handle
    public AudioSource waterSound; // Optional: Water sound effect
    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Press 'F' to toggle the tap
        {
            if (!isOpen)
            {
                tapHandle.Rotate(Vector3.forward * -45f); // Rotate tap to open
                waterSound.Play(); // Play water sound
            }
            else
            {
                tapHandle.Rotate(Vector3.forward * 45f); // Rotate back to close
                waterSound.Stop();
            }
            isOpen = !isOpen;
        }
    }
}
