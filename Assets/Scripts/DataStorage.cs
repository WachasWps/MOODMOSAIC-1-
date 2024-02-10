using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class DataStorage : MonoBehaviour
{
    public TMP_Dropdown professionDropdown;
    public TMP_Dropdown genderDropdown;
    public TMP_InputField ageInputField;

    private string selectedProfession;
    private string selectedGender;
    private int age;

    private void Start()
    {
        Button nextButton = GetComponent<Button>();
        nextButton.onClick.AddListener(StoreData);
    }

    public void StoreData()
    {
        selectedProfession = professionDropdown.options[professionDropdown.value].text;
        selectedGender = genderDropdown.options[genderDropdown.value].text;
        int.TryParse(ageInputField.text, out age);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Now you can use selectedProfession, selectedGender, and age for further processing or storing in a data structure
    }
}
