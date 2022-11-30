using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RacketAI : MonoBehaviour
{
    float racketMoveSpeed;
    int racketModifier;
    //PlayerPrefs.SetFloat("racketMoveSpeed", 0f);
    public GameObject ball;
    LevelManager levelManager;

    private void Awake()
    {
        //levelManager = FindObjectOfType<LevelManager>();
    }
    public void DifficultyUpdateEasy()
    {
        //int racketModifier = 33;
        //racketMoveSpeed = 33;
        //Debug.Log($"Easy mode, racketMoveSpeed: {racketMoveSpeed}");
        //SetRacketSpeed(racketModifier);
        //return;
        // Do I need a return here?
        //player2Script.UpdateSpeed(50);
        int difficulty = 0;
        GetRacketSpeed(difficulty);
    }

    public void DifficultyUpdateMedium()
    {
        //var racketModifier = 44;
        //Debug.Log($"Medium mode");
        //SetRacketSpeed(racketModifier);
        int difficulty = 1;
        GetRacketSpeed(difficulty);
        //return;
    }
    public void DifficultyUpdateHard()
    {
        //var racketModifier = 55;
        //Debug.Log($"Hard mode");
        //SetRacketSpeed(racketModifier);
        int difficulty = 2;
        GetRacketSpeed(difficulty);
        //return;
    }
    public void SetRacketSpeed(int value)
    {
        //int racketMoveSpeed = 0;
        racketMoveSpeed += value;
        //int racketMoveSpeed = value;
        //GetRacketSpeed();
    }
    public int GetRacketSpeed(int difficulty)
    {
        if (difficulty == 0)
        {
            //Easy
            racketModifier = 33;
            //Debug.Log($"Easy mode, racketMoveSpeed: {racketModifier}");
            PlayerPrefs.SetInt("Racket Move Speed", racketModifier);
            SimplePass(racketModifier);
            return racketModifier;
        }
        else if (difficulty == 1)
        {
            racketModifier = 44;
            //Debug.Log($"Medium mode");
            PlayerPrefs.SetInt("Racket Move Speed", racketModifier);
            Debug.Log($"Medium mode");
            SimplePass(racketModifier);
            return racketModifier;
        }
        else
        {
            //Hard
            racketModifier = 55;
            //Debug.Log($"Hard mode");
            PlayerPrefs.SetInt("Racket Move Speed", racketModifier);
            SimplePass(racketModifier);
            return racketModifier;
        }
        //PlayerPrefs.SetInt("Racket Move Speed", racketMoveSpeed);
        //Debug.Log($"racketMoveSpeed: {racketMoveSpeed}");
        //return racketMoveSpeed;
    }
    void RacketUpdate(float racketMoveSpeed)
    {
        Debug.Log($"speed is {racketMoveSpeed}");
        //Racket move speed needs to be defined inside of Update.
        //Debug.Log($"racketMoveSpeed: {racketMoveSpeed}");
        //SimplePass();
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) < 50)
        {
            //GetRacketSpeed();
            
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * racketMoveSpeed;
                //Debug.Log("Testing speed:" + racketMoveSpeed);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * racketMoveSpeed;
                //Debug.Log("Testing speed:" + racketMoveSpeed);
            }
        }
        else
        {
            int yRandom = Random.Range(0, 10);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, yRandom) * racketMoveSpeed;
            //// Don't need an x value because locked into x-axis.
        }
        //SimplePass();
    }
    void SimplePass(int value)
    {
        float racketMoveSpeed = value;
        //Debug.Log($"speed is {racketMoveSpeed}");
        RacketUpdate(racketMoveSpeed);
    }
    void Test()
    {

    }
    void Update()
    {
        //racketMoveSpeed = 77; //Racket move speed needs to be defined inside of Update.
        //if (Mathf.Abs(transform.position.y - ball.transform.position.y) < 50)
        //{
        //    //GetRacketSpeed();
        //    if (transform.position.y < ball.transform.position.y)
        //    {
        //        //GetRacketSpeed();
        //        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * racketMoveSpeed ;
        //        //Debug.Log("Testing speed:" + racketMoveSpeed);
        //    }
        //    else
        //    {
        //        //GetRacketSpeed();
        //        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * racketMoveSpeed ;
        //        //Debug.Log("Testing speed:" + racketMoveSpeed);
        //    }
        //}
        //else
        //{
        //    int yRandom = Random.Range(0, 10);
        //    //GetComponent<Rigidbody2D>().velocity = new Vector2(0, yRandom) * racketMoveSpeed;
        //    //// Don't need an x value because locked into x-axis.
        //}
    }
}
