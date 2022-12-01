using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RacketAI : MonoBehaviour
{
    float racketMoveSpeed;
    public GameObject ball;
    LevelManager levelManager;

    private void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    public void DifficultyUpdateEasy()
    {
        LevelManager.LoadCPU();
        PlayerPrefs.SetInt("Difficulty", 0);
    }
    public void DifficultyUpdateMedium()
    {
        LevelManager.LoadCPU();
        PlayerPrefs.SetInt("Difficulty", 1);
    }
    public void DifficultyUpdateHard()
    {
        LevelManager.LoadCPU();
        PlayerPrefs.SetInt("Difficulty", 2);
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
        {
            racketMoveSpeed = 50;
            Debug.Log($"Easy mode, racket speed: {racketMoveSpeed}");
        }
        else if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            racketMoveSpeed = 100;
            Debug.Log($"Medium mode, racket speed: {racketMoveSpeed}");
        }
        else if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            racketMoveSpeed = 150;
            Debug.Log($"Hard mode, racket speed: {racketMoveSpeed}");
        }
        else
        {
            racketMoveSpeed = 0;
            Debug.Log($"Difficult not selected, racket speed: {racketMoveSpeed}");
        }
        //Racket move speed needs to be defined inside of Update.
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) < 50)
        {
            //GetRacketSpeed();
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * racketMoveSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * racketMoveSpeed;
            }
        }
        else
        {
            int yRandom = Random.Range(0, 10);
        }
    }
}
