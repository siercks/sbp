using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelManager : MonoBehaviour
{
    //
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
}
