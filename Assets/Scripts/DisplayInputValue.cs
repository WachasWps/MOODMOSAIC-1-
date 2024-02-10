using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayInputValue : MonoBehaviour
{
    public TMP_Text displayText;

    void Start()
    {
        // Retrieve the input value from PlayerPrefs
        string inputValue = PlayerPrefs.GetString("InputValue", "");

        // Display the input value
        displayText.text = inputValue;
    }
}
