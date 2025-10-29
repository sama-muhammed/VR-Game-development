using UnityEngine;
using UnityEngine.UI;

public class FaucetController : MonoBehaviour
{
    public ParticleSystem waterEffect; // Assign the WaterEffect Particle System
    public AudioSource waterSound; // Assign a water sound effect (optional)
    private bool isRunning = false;

    public void ToggleWater()
    {
        if (!isRunning)
        {
            waterEffect.Play();  // Start water flow
            if (waterSound != null) waterSound.Play();
        }
        else
        {
            waterEffect.Stop();  // Stop water flow
            if (waterSound != null) waterSound.Stop();
        }
        isRunning = !isRunning;
    }
}
