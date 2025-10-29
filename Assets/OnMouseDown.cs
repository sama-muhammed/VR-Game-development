using UnityEngine;

public class PlayButtonClick : MonoBehaviour
{
    public FaucetController faucet; // Assign the faucet object in Unity Inspector

    private void OnMouseDown()
    {
        if (faucet != null)
        {
            faucet.ToggleWater();
        }
    }
}
