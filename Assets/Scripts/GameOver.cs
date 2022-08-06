using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool OnGame;
    public GameObject Main , LevelMenu, Settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnGame == false)
        {
            if (PlayerPrefs.GetInt("LevelsOpen") == 1)
            {
                LevelMenu.SetActive(true);
                Main.SetActive(false);
                PlayerPrefs.SetInt("LevelsOpen", 0);
            }
            if (PlayerPrefs.GetInt("SettingsOpen") == 1)
            {
                Settings.SetActive(true);
                PlayerPrefs.SetInt("SettingsOpen", 0);
            }
        }
    }
    public void Levels()
    {
        PlayerPrefs.SetInt("LevelsOpen", 1);
        Home();

    }
    public void Settingss()
    {
        PlayerPrefs.SetInt("SettingsOpen", 1);
        Home();
    }
    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("SettingsOpen", 0);
        PlayerPrefs.SetInt("LevelsOpen", 0);

    }
}
