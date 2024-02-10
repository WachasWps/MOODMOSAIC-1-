using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Text textBox;
    public Color extrovertColor;
    public Color introvertColor;
    public Color perceivingColor;
    public Color sensingColor;
    public Color thinkingColor;

    public void OnScoreButtonClick(string scoreType)
    {
        switch (scoreType)
        {
            case "extrovert":
                textBox.text = "Text related to Extrovert";
                textBox.GetComponent<Image>().color = extrovertColor;
                break;
            case "introvert":
                textBox.text = "Text related to Introvert";
                textBox.GetComponent<Image>().color = introvertColor;
                break;
            case "perceiving":
                textBox.text = "Text related to Perceiving";
                textBox.GetComponent<Image>().color = perceivingColor;
                break;
            case "sensing":
                textBox.text = "Text related to Sensing";
                textBox.GetComponent<Image>().color = sensingColor;
                break;
            case "thinking":
                textBox.text = "Text related to Thinking";
                textBox.GetComponent<Image>().color = thinkingColor;
                break;
            default:
                break;
        }
    }
}
