using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject difficultySelectMenu;
    public static bool isDifficultySelected = false;
    RacketAI racketAI;
    public static int difficultyNumber;
    public LevelManager()
    {

    }
    private void Awake()
    {
        racketAI = FindObjectOfType<RacketAI>();
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
    public static void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ShowDifficultyMenu()
    {
        difficultySelectMenu.SetActive(true);
        isDifficultySelected = true;
    }
    public void HideDifficultyMenu()
    {
        difficultySelectMenu.SetActive(false);
        isDifficultySelected = false;
    }
}
