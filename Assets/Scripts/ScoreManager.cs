using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textBox;
    public Image textBoxBackground;
    public void ShowExtrovertSuggestions()
    {
        // Change text box background color
        textBoxBackground.color = new Color(255f / 255f, 88f / 255f, 212f / 255f); // Hex color FF58D4

        // Display suggestions based on the score range
        int extrovertScore = GetExtrovertScore(); // Implement this function to get the score
        if (extrovertScore >= 0 && extrovertScore <= 5)
        {
            textBox.text = "Your extrovert score is too low. Try engaging in more social activities to improve.";
        }
        else if (extrovertScore >= 6 && extrovertScore <= 10)
        {
            textBox.text = "You have a moderate extrovert score. Consider stepping out of your comfort zone occasionally.";
        }
        else if (extrovertScore >= 11 && extrovertScore <= 15)
        {
            textBox.text = "You have a high extrovert score. Keep engaging in social activities to maintain it.";
        }
        else if (extrovertScore >= 16 && extrovertScore <= 20)
        {
            textBox.text = "Your extrovert score is very high. Continue leveraging your strong communication skills.";
        }
    }
    public void ShowIntrovertSuggestions()
    {
        // Change text box background color
        textBoxBackground.color = new Color(255f / 255f, 226f / 255f, 31f / 255f); // Hex color FFE21F

        // Display suggestions based on the score range
        int introvertScore = GetIntrovertScore(); // Implement this function to get the score
        if (introvertScore >= 0 && introvertScore <= 5)
        {
            textBox.text = "Your introvert score is too low. Remember to prioritize alone time to recharge.";
        }
        else if (introvertScore >= 6 && introvertScore <= 10)
        {
            textBox.text = "You have a moderate introvert score. Embrace your need for solitude while also challenging yourself.";
        }
        else if (introvertScore >= 11 && introvertScore <= 15)
        {
            textBox.text = "Your introvert score is high. Acknowledge your preference for introspection and quiet environments.";
        }
        else if (introvertScore >= 16 && introvertScore <= 20)
        {
            textBox.text = "Your introvert score is very high. Embrace your strengths in deep thinking and introspection.";
        }
    }

    public void ShowSensingSuggestions()
    {
        // Change text box background color
        textBoxBackground.color = new Color(255f / 255f, 161f / 255f, 0f); // Hex color FFA100

        // Display suggestions based on the score range
        int sensingScore = GetSensingScore(); // Implement this function to get the score
        if (sensingScore >= 0 && sensingScore <= 5)
        {
            textBox.text = "Your sensing score is too low. Pay attention to your surroundings and try to be more present in the moment.";
        }
        else if (sensingScore >= 6 && sensingScore <= 10)
        {
            textBox.text = "You have a moderate sensing score. Continue to develop your observational skills by actively engaging with your environment.";
        }
        else if (sensingScore >= 11 && sensingScore <= 15)
        {
            textBox.text = "Your sensing score is high. Your keen observation skills serve you well in navigating the physical world.";
        }
        else if (sensingScore >= 16 && sensingScore <= 20)
        {
            textBox.text = "Your sensing score is very high. Your ability to appreciate and engage with your surroundings is exceptional.";
        }
    }

    public void ShowPerceivingSuggestions()
    {
        // Change text box background color
        textBoxBackground.color = new Color(255f / 255f, 242f / 255f, 0f); // Hex color FFF200

        // Display suggestions based on the score range
        int perceivingScore = GetPerceivingScore(); // Implement this function to get the score
        if (perceivingScore >= 0 && perceivingScore <= 5)
        {
            textBox.text = "Your perceiving score is too low. Embrace spontaneity and flexibility by allowing yourself to adapt to new situations and explore different possibilities.";
        }
        else if (perceivingScore >= 6 && perceivingScore <= 10)
        {
            textBox.text = "You have a moderate perceiving score. Continue to cultivate your adaptability and openness to new experiences.";
        }
        else if (perceivingScore >= 11 && perceivingScore <= 15)
        {
            textBox.text = "Your perceiving score is high. Your flexible mindset allows you to thrive in dynamic environments.";
        }
        else if (perceivingScore >= 16 && perceivingScore <= 20)
        {
            textBox.text = "Your perceiving score is very high. Embrace your flexible nature and use it to your advantage.";
        }
    }

    public void ShowThinkingSuggestions()
    {
        // Change text box background color
        textBoxBackground.color = new Color(145f / 255f, 255f / 255f, 0f); // Hex color 91FF00

        // Display suggestions based on the score range
        int thinkingScore = GetThinkingScore(); // Implement this function to get the score
        if (thinkingScore >= 0 && thinkingScore <= 5)
        {
            textBox.text = "Your thinking score is too low. Focus on developing your analytical skills by practicing critical thinking and problem-solving exercises.";
        }
        else if (thinkingScore >= 6 && thinkingScore <= 10)
        {
            textBox.text = "You have a moderate thinking score. Continue to refine your logical reasoning abilities by seeking out intellectually stimulating tasks and environments.";
        }
        else if (thinkingScore >= 11 && thinkingScore <= 15)
        {
            textBox.text = "Your thinking score is high. Your logical approach to problem-solving is commendable.";
        }
        else if (thinkingScore >= 16 && thinkingScore <= 20)
        {
            textBox.text = "Your thinking score is very high. Your sharp analytical mind is a valuable asset.";
        }
    }

    // Add similar methods for other personality traits

    private int GetExtrovertScore()
    {
        // Implement this function to retrieve the extrovert score from your system
        // For demonstration purposes, return a random score between 0 and 20
        return Random.Range(0, 21);
    }

    private int GetIntrovertScore()
    {
        // Implement this function to retrieve the introvert score from your system
        // For demonstration purposes, return a random score between 0 and 20
        return Random.Range(0, 21);
    }

    private int GetSensingScore()
    {
        // Implement this function to retrieve the sensing score from your system
        // For demonstration purposes, return a random score between 0 and 20
        return Random.Range(0, 21);
    }

    private int GetPerceivingScore()
    {
        // Implement this function to retrieve the perceiving score from your system
        // For demonstration purposes, return a random score between 0 and 20
        return Random.Range(0, 21);
    }

    private int GetThinkingScore()
    {
        // Implement this function to retrieve the thinking score from your system
        // For demonstration purposes, return a random score between 0 and 20
        return Random.Range(0, 21);
    }
}
