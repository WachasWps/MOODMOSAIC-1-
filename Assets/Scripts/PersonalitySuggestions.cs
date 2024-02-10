using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonalitySuggestions : MonoBehaviour
{
    public TMP_Text suggestionTextArea;

    // Suggestions for Extrovert
    private string[][] extrovertSuggestions = {
        new string[] {"Volunteer at community events", "Attend a networking event", "Join a small group workout session"},
        new string[] {"Organize a casual get together", "Attend live concerts", "Participate in hiking or biking with friends"},
        new string[] {"Take on leadership roles in community", "Plan a weekend trip with close friends", "Host gatherings"}
    };

    // Suggestions for Introvert
    private string[][] introvertSuggestions = {
        new string[] {"Engage in intimate small gatherings", "Solo hikes or traveling", "Spend quiet evenings with reading books, etc"},
        new string[] {"Dedicate regular me time", "Explore gardening", "Engage in intellectual events"},
        new string[] {"Explore deep connections with few close friends", "Seek out opportunities for personal growth", "Write poems or journals"}
    };

    // Suggestions for Sensing
    private string[][] sensingSuggestions = {
        new string[] {"Engage in creative activities like painting, drawing, sculpting", "Take mindful meditation and yoga practices", "Attend live performances"},
        new string[] {"Plan a day trip to visit local museum and historical sites", "Participate in DIY or woodworking", "Take up a hobby such as bird watching or photography"},
        new string[] {"Participate in camping, fishing", "Volunteer for conservation or environmental restoration events", "Attend chocolate tours"}
    };

    // Suggestions for Thinking
    private string[][] thinkingSuggestions = {
        new string[] {"Engage in creative activities such as storytelling or creative writing", "Attend theater performances or dance recitals", "Practice mindful meditation"},
        new string[] {"Engage in problem-solving puzzles", "Participate in debates", "Volunteer for social causes"},
        new string[] {"Engage in research projects", "Participate in coding boot camps", "Engage in startups"}
    };

    // Suggestions for Perceiving
    private string[][] perceivingSuggestions = {
        new string[] {"Engage in a specific workout routine", "Set specific deadlines for personal projects", "Participate in team sports"},
        new string[] {"Explore open-ended art projects", "Embrace experiences of spontaneous trips", "Explore uncharted hiking trails"},
        new string[] {"Engage in creative pursuits of self-discovery", "Travel unfamiliar destinations", "Connect with people with the same outlook on life"}
    };

    // Function to display suggestions based on the selected personality trait
    public void DisplaySuggestions(string personalityTrait, int score)
    {
        string[][] suggestions = null;

        // Determine which set of suggestions to use based on the personality trait
        switch (personalityTrait)
        {
            case "Extrovert":
                suggestions = extrovertSuggestions;
                break;
            case "Introvert":
                suggestions = introvertSuggestions;
                break;
            case "Sensing":
                suggestions = sensingSuggestions;
                break;
            case "Thinking":
                suggestions = thinkingSuggestions;
                break;
            case "Perceiving":
                suggestions = perceivingSuggestions;
                break;
            default:
                break;
        }

        // Display suggestions based on the score range
        if (suggestions != null && score >= 0 && score <= 5)
        {
            suggestionTextArea.text = string.Join("\n", suggestions[0]);
        }
        else if (suggestions != null && score > 5 && score <= 10)
        {
            suggestionTextArea.text = string.Join("\n", suggestions[1]);
        }
        else if (suggestions != null && score > 10 && score <= 15)
        {
            suggestionTextArea.text = string.Join("\n", suggestions[2]);
        }
        else
        {
            // Display a default message if the score is out of range
            suggestionTextArea.text = "Invalid score range.";
        }
    }
}
