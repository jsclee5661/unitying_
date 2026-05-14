using UnityEngine;

public class Interactable : MonoBehaviour
{
    [TextArea]
    public string message;

    private DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = FindFirstObjectByType<DialogueManager>();
    }

    public void Interact()
    {
        dialogueManager.ShowDialogue(message);
    }
}