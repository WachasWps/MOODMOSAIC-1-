using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneTransition : MonoBehaviour
{
    public Image fadeImage;
    public TMP_Text[] fadeTexts;
    public Button[] fadeButtons;
    public float fadeDuration = 1f;

    IEnumerator Start()
    {
        // Set up fade objects
        fadeImage.gameObject.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0);

        foreach (TMP_Text text in fadeTexts)
        {
            text.canvasRenderer.SetAlpha(0);
        }

        foreach (Button button in fadeButtons)
        {
            button.gameObject.SetActive(false);
        }

        // Fade in
        fadeImage.CrossFadeAlpha(1, fadeDuration, true);

        foreach (TMP_Text text in fadeTexts)
        {
            text.CrossFadeAlpha(1, fadeDuration, true);
        }

        foreach (Button button in fadeButtons)
        {
            button.gameObject.SetActive(true);
            Image buttonImage = button.GetComponent<Image>();
            if (buttonImage != null)
            {
                buttonImage.CrossFadeAlpha(1, fadeDuration, true);
            }
            TextMeshProUGUI[] buttonTexts = button.GetComponentsInChildren<TextMeshProUGUI>();
            foreach (TextMeshProUGUI buttonText in buttonTexts)
            {
                buttonText.CrossFadeAlpha(1, fadeDuration, true);
            }
        }

        // Wait for fade in to complete
        yield return new WaitForSeconds(fadeDuration);

        // Load the next scene asynchronously

    }
}
