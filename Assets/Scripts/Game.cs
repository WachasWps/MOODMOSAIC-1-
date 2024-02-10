using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    private static Game instance;

    private int extrovert;
    private int introvert;
    private int sensing;
    private int thinking;
    private int perceiving;

    // Singleton instance
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddToExtrovert(int valueToAdd)
    {
        extrovert += valueToAdd;
    }

    public void AddToIntrovert(int valueToAdd)
    {
        introvert += valueToAdd;
        
    }

    public void AddToSensing(int valueToAdd)
    {
        sensing += valueToAdd;
    }

    public void AddToPerceiving(int valueToAdd)
    {
        perceiving += valueToAdd;
    }

     public void AddToThinking(int valueToAdd)
    {
        thinking += valueToAdd;
    }
    // Other AddTo... functions

    // Getters for variable values
    public int GetExtrovert() => extrovert;
    public int GetIntrovert() => introvert;
    public int GetSensing() => sensing;
    public int GetThinking() => thinking;
    public int GetPerceiving() => perceiving;

    // Function to change scene
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
