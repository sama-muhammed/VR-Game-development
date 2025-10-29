using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform handPosition; // Assign in Inspector
    private GameObject heldObject;
    private Rigidbody objectRb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Press 'E' to pick/drop
        {
            if (heldObject == null)
            {
                TryPickUp();
            }
            else
            {
                DropObject();
            }
        }
    }

    void TryPickUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2f))
        {
            if (hit.collider.CompareTag("Pickup")) // Ensure cup has the "Pickup" tag
            {
                heldObject = hit.collider.gameObject;
                objectRb = heldObject.GetComponent<Rigidbody>();

                objectRb.useGravity = false;
                objectRb.isKinematic = true;

                heldObject.transform.position = handPosition.position;
                heldObject.transform.parent = handPosition;
            }
        }
    }

    void DropObject()
    {
        objectRb.useGravity = true;
        objectRb.isKinematic = false;

        heldObject.transform.parent = null;
        heldObject = null;
    }
}
