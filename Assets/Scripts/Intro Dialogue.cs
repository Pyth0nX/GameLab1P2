using UnityEngine;
using UnityEngine.UI;

public class introDialogue : MonoBehaviour
{
    public GameObject dialogueImage;  // Reference to the dialogue Image object (PNG)
    public Button closeButton;        // Reference to the close button

    private void Start()
    {
        // Show the dialogue image
        dialogueImage.SetActive(true);

        // Show the close button
        closeButton.gameObject.SetActive(true);

        // Add a listener to the button to close the dialogue when clicked
        closeButton.onClick.AddListener(CloseDialogue);
    }

    // Method to close the dialogue
    private void CloseDialogue()
    {
        dialogueImage.SetActive(false);
        closeButton.gameObject.SetActive(false);
    }
}
