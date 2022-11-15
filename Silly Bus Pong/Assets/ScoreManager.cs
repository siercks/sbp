using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI scoreTextPlayer1;
    int scorePlayer1;
    //[SerializeField] TextMeshProUGUI scoreTextPlayer2;
    int scorePlayer2;
    BallMovement ballMovement;
    LevelManager levelManager;
    // Start is called before the first frame update
    void Awake()
    {
        ballMovement = FindObjectOfType<BallMovement>();
        levelManager = FindObjectOfType<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LeftWall")
        {
            GoalPlayer2();
            ballMovement.PositionBall();
            EndGame();
        }
        else if (other.tag == "RightWall")
        {
            GoalPlayer1();
            ballMovement.PositionBall();
            EndGame();
        }
    }
    public int GetPlayer1Score()
    {
        PlayerPrefs.SetInt("Player 1 Score", scorePlayer1);
        return scorePlayer1;
    }
    public int GetPlayer2Score()
    {
        PlayerPrefs.SetInt("Player 2 Score", scorePlayer2);
        return scorePlayer2;
    }

    public void GoalPlayer1()
    {
        scorePlayer1 = scorePlayer1 + 1;
        Mathf.Clamp(scorePlayer1, 0, 7);
        // GetPlayer1Score(); // Put this in while troubleshooting score. Ultimately, not needed.
        Debug.Log($"Point for Player 1! Player 1: {scorePlayer1}, Player 2: {scorePlayer2}");
        ballMovement.PositionBall();
    }
    public void GoalPlayer2()
    {
        scorePlayer2 += 1;
        Mathf.Clamp(scorePlayer2, 0, 7);
        //GetPlayer2Score();
        Debug.Log($"Point for Player 2! Player 1: {scorePlayer1}, Player 2: {scorePlayer2}");
        ballMovement.PositionBall();
    }
    public void EndGame() // This checks win conditions. It works as of 11/15.
    {
        if (scorePlayer2 == 7)
        {
            Debug.Log("Game over! Player 2 wins!");
            //Can I port over the winner to GameOver?
            SceneManager.LoadScene("GameOver");
        }
        else if (scorePlayer1 == 7)
        {
            Debug.Log("Game over! Player 1 wins!");
            SceneManager.LoadScene("GameOver");

        }
        else
        {
            return;
        }
    }
}
