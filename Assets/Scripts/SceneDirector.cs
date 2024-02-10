using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneDirector : MonoBehaviour
{
    public TMP_Dropdown professionDropdown;
    public TMP_Dropdown genderDropdown;
    public TMP_InputField ageInputField;

    public void StoreDataAndDirectScene()
    {
        // Store the data
        string selectedProfession = professionDropdown.options[professionDropdown.value].text;
        string selectedGender = genderDropdown.options[genderDropdown.value].text;
        int age;
        int.TryParse(ageInputField.text, out age);

        PlayerPrefs.SetString("SelectedProfession", selectedProfession);
        PlayerPrefs.SetString("SelectedGender", selectedGender);
        PlayerPrefs.SetInt("Age", age);

        // Determine scenario based on stored data
        int scenarioNumber = DetermineScenario(selectedGender, selectedProfession, age);

        // Direct to the appropriate scene
        SceneManager.LoadScene("Scenario" + scenarioNumber);
    }

    private int DetermineScenario(string gender, string profession, int age)
    {
        // Add your logic here to determine the scenario based on the stored data
        // For example, you can use if-else statements or switch-case statements
        
        // Example logic:
        if (profession == "Student")
        {
            return 1; // Scenario 1 
        }
        else if (profession == "Employee")
        {
            return 1; // Scenario 8
        }
        else if (profession == "Artist")
        {
            return 1; // Scenario 8
        }
        else if (profession == "Businessman")
        {
            return 121; // Scenario 8
        }
        else
        {
            return 1; // Default scenario
        }
    }
}
