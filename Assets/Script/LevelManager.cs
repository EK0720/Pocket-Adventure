using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] List<GameObject> levelButtons; // Danh sách các nút level trên menu
    [SerializeField] Sprite lockedSprite; // Sprite mờ cho level chưa mở khóa

    void Start()
    {
        // Kiểm tra trạng thái của các level và làm mờ các level chưa mở khóa
        for (int i = 0; i < levelButtons.Count; i++)
        {
            if (IsLevelUnlocked(i + 1))
            {
                levelButtons[i].GetComponent<SpriteRenderer>().sprite = null;
            }
            else
            {
                levelButtons[i].GetComponent<SpriteRenderer>().sprite = lockedSprite;
            }
        }
    }

    // Kiểm tra xem level có mở khóa hay không
    public bool IsLevelUnlocked(int levelIndex)
    {
        return PlayerPrefs.GetInt("UnlockedLevel", 1) >= levelIndex;
    }

    // Mở khóa level
    public void UnlockLevel(int levelIndex)
    {
        if (IsLevelUnlocked(levelIndex))
        {
            return;
        }

        PlayerPrefs.SetInt("UnlockedLevel", levelIndex);
    }

    // Load level
    public void LoadLevel(int levelIndex)
    {
        if (!IsLevelUnlocked(levelIndex))
        {
            return;
        }
        SceneManager.LoadScene(levelIndex+1);
    }

    public void ResetLevels()
    {
        PlayerPrefs.DeleteAll();
    }
}