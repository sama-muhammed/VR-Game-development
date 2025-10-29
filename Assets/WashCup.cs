using UnityEngine;

public class WashCup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Debug.Log("Cup is being washed!");
        }
    }
}
