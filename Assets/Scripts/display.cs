using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class display : MonoBehaviour
{
    public TMP_Text extrovertDisplayText;
    public TMP_Text introvertDisplayText;
    public TMP_Text sensingDisplayText;
    public TMP_Text thinkingDisplayText;
    public TMP_Text perceivingDisplayText;

    void Start()
    {
        // Find the Game object in the scene
        Game game = FindObjectOfType<Game>();

        // Check if the Game object exists
        if (game != null)
        {
            // Access the variable values from the Game object
            int extrovertValue = game.GetExtrovert();
            int introvertValue = game.GetIntrovert();
            int sensingValue = game.GetSensing();
            int thinkingValue = game.GetThinking();
            int perceivingValue = game.GetPerceiving();

            // Display the variable values in the Text components
            extrovertDisplayText.text = extrovertValue.ToString();
            introvertDisplayText.text = introvertValue.ToString();
            sensingDisplayText.text = sensingValue.ToString();
            thinkingDisplayText.text = thinkingValue.ToString();
            perceivingDisplayText.text = perceivingValue.ToString();
        }
        else
        {
            Debug.LogWarning("Game object not found in the scene!");
        }
    }
}
