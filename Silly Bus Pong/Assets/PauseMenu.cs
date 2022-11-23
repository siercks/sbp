using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isGamePaused = false;
    [SerializeField] GameObject ourPauseMenu;
    BallMovement ballMovement;

    void Awake()
    {
        ballMovement = FindObjectOfType<BallMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGamePaused)
            {
                ResumeGame();
                AudioListener.pause = false;
            }
            else
            {
                PauseGame();
                AudioListener.pause = true;
            }
        }
    }
    public void PauseGame()
    {
        ourPauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void ResumeGame()
    {
        ourPauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void ResetDeadBall()
    {
        ballMovement.PositionBall();
        ourPauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
