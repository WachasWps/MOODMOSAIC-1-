using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneToStart : MonoBehaviour
{
    public Button yourButton; // Drag and drop your button in the Inspector

    void Start()
    {
        yourButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("CharacterScene");
    }
}
