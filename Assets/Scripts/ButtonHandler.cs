using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public PersonalitySuggestions personalitySuggestions;
    public string personalityTrait;
    public int score;

    // Method to handle button click
    public void OnButtonClick()
    {
        // Call DisplaySuggestions method with specified personality trait and score
        personalitySuggestions.DisplaySuggestions(personalityTrait, score);
    }
}
