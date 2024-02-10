using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class add : MonoBehaviour
{
    public TMP_Text variableDisplayText; // Reference to the Text component in the scene

    // Function to add value to extrovert variable
    public void AddToExtrovert(int extrovertValue)
    {
        // Find the GameManager object in the scene
        Game gameManager = FindObjectOfType<Game>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call method to add value to the extrovert variable
            gameManager.AddToExtrovert(extrovertValue);
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }

    // Function to add value to introvert variable
    public void AddToIntrovert(int introvertValue)
    {
        // Find the GameManager object in the scene
        Game gameManager = FindObjectOfType<Game>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call method to add value to the introvert variable
            gameManager.AddToIntrovert(introvertValue);
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }

    public void AddToSensing(int sensingValue)
    {
        // Find the GameManager object in the scene
        Game gameManager = FindObjectOfType<Game>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call method to add value to the introvert variable
            gameManager.AddToSensing(sensingValue);
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }

    public void AddToPerceiving(int perceivingValue)
    {
        // Find the GameManager object in the scene
        Game gameManager = FindObjectOfType<Game>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call method to add value to the introvert variable
            gameManager.AddToPerceiving(perceivingValue);
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }

    public void AddToThinking(int thinkingValue)
    {
        // Find the GameManager object in the scene
        Game gameManager = FindObjectOfType<Game>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call method to add value to the introvert variable
            gameManager.AddToThinking(thinkingValue);
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
