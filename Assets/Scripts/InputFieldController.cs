using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InputFieldController : MonoBehaviour
{
    public TMP_InputField inputField;

    // Function to be called when the button is clicked
    public void OnButtonClick()
    {
        // Store the input value
        string inputValue = inputField.text;

        // Pass the input value to the next scene using PlayerPrefs
        PlayerPrefs.SetString("InputValue", inputValue);

        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
