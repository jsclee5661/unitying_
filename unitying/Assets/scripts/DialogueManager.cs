using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;

    private bool isShowing = false;

    public void ShowDialogue(string message)
    {
        dialoguePanel.SetActive(true);
        dialogueText.text = message;
        isShowing = true;
    }

    void Update()
    {
        if (isShowing && Input.GetKeyDown(KeyCode.Space))
        {
            HideDialogue();
        }
    }

    public void HideDialogue()
    {
        dialoguePanel.SetActive(false);
        isShowing = false;
    }
}