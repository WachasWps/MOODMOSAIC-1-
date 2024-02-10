using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeTextOnButtonClick : MonoBehaviour
{
    public TMP_Text textComponent;
    public string newText = "value";

    void Start()
    {
        // Ensure the Text component is assigned to the script.
        if (textComponent == null)
        {
            Debug.LogError("Text component not assigned to the script. Please assign it in the Inspector.");
        }
    }

    public void OnButtonClick()
    {
        // Change the text when the button is clicked.
        if (textComponent != null)
        {
            textComponent.text = newText;
        }
    }
}