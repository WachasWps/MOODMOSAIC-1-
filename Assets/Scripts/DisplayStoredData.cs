using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayStoredData : MonoBehaviour
{
    public TextMeshProUGUI professionText;
    public TextMeshProUGUI genderText;
    public TextMeshProUGUI ageText;

    void Start()
    {
        // Retrieve stored data
        string selectedProfession = PlayerPrefs.GetString("SelectedProfession");
        string selectedGender = PlayerPrefs.GetString("SelectedGender");
        int age = PlayerPrefs.GetInt("Age");

        // Display stored data in UI elements
        professionText.text = "Profession: " + selectedProfession;
        genderText.text = "Gender: " + selectedGender;
        ageText.text = "Age: " + age.ToString();
    }
}
