using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Interactable currentTarget;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentTarget != null)
        {
            currentTarget.Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Interactable interactable = collision.GetComponent<Interactable>();

        if (interactable != null)
        {
            currentTarget = interactable;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Interactable interactable = collision.GetComponent<Interactable>();

        if (interactable != null && interactable == currentTarget)
        {
            currentTarget = null;
        }
    }
}