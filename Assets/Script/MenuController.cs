using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject SettingContainer;
    [SerializeField] GameObject LevelContainer;
    // Start is called before the first frame update
    public void ShowSettings()
    {
        SettingContainer.SetActive(true);
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void HideSettings()
    {
        SettingContainer.SetActive(false);
    }
    public void ShowLevel()
    {
        LevelContainer.SetActive(true);
    }
    public void HideLevel()
    {
        LevelContainer.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
