using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject difficultySelectMenu;
    public static bool isDifficultySelected = false;
    public LevelManager()
    {

    }
    private void Awake()
    {
        //
    }
    void Start()
    {
        //Invoke("GoToMainMenu", 5f);
        
    }

    void Update()
    {
        if (isDifficultySelected)
        {
            ShowDifficultyMenu();
        }
        else
        {
            HideDifficultyMenu();
        }
    }

    // Update is called once per frame
    public static void LoadPVP() 
    {
        SceneManager.LoadScene("GamePVP");
    }
    public static void LoadCPU()
    {
        SceneManager.LoadScene("GameCPU");
    }
    public static void GameOver()
    {
        //SceneManager.LoadScene("GameOver");
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
    public void ShowDifficultyMenu()
    {
        difficultySelectMenu.SetActive(true);

    }
    public void HideDifficultyMenu()
    {
        difficultySelectMenu.SetActive(false);
    }
}
