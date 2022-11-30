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
    public int difficultyNumber;
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
        isDifficultySelected = true;
    }
    public void HideDifficultyMenu()
    {
        difficultySelectMenu.SetActive(false);
        isDifficultySelected = false;
    }
    //public void DifficultySelections()
    //{
    //    //var difficultyNumber = 0;
    //    if (isDifficultySelected == true)
    //    {
    //        switch (difficultyNumber)
    //        {
    //            case 0:
    //                //Easy
    //                SceneManager.LoadScene("GameCPU");
    //                //racketAI.DifficultyUpdateEasy();
    //                break;
    //             case 1:
    //                //Medium
    //                Debug.Log($"Medium mode");
    //                racketAI.DifficultyUpdateMedium();
    //                SceneManager.LoadScene("GameCPU");
    //                break; 
    //            case 2:
    //                //Hard
    //                racketAI.DifficultyUpdateHard();
    //                SceneManager.LoadScene("GameCPU");
    //                break;
    //        }
    //    }
    //}
}
