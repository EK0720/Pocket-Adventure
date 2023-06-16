using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuGameController : MonoBehaviour
{
    [SerializeField] GameObject PauseContainer;
    [SerializeField] GameObject OptionContainer;    
    [SerializeField] GameObject LevelComplete;   
    void Start()
    {
        if (PlayerPrefs.HasKey("UnlockedLevel"))
        {
            unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel");
        }
        else
        {
            unlockedLevel = 1;
        }
    } 
    int unlockedLevel;
    public void ShowPause()
    {
        PauseContainer.SetActive(true);
    }
    public void HidePause()
    {
        PauseContainer.SetActive(false);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void LoadOptions()
    {
        OptionContainer.SetActive(true);
    }
    public void HideOptions()
    {
        OptionContainer.SetActive(false);
    }
    public void ShowLevelComplete()
    {
        LevelComplete.SetActive(true);
    }
    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
            PlayerPrefs.SetInt("UnlockedLevel", nextSceneIndex);
        }
    }
}
