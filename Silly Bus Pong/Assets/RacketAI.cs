using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketAI : MonoBehaviour
{
    public int racketMoveSpeed = 0; 
    //PlayerPrefs.SetFloat("racketMoveSpeed", 0f);
    public GameObject ball;
    Player2Script player2Script;
    LevelManager levelManager;

    private void Awake()
    {
        //player2Script = FindObjectOfType<Player2Script>();
        // Don't need to even touch the above script, as the Racket and Racket AI don't even look at it.
        //levelManager = FindObjectOfType<LevelManager>();
    }
    public void DifficultyUpdateEasy()
    {
        racketMoveSpeed = 33;
        //Debug.Log($"Easy mode, racketMoveSpeed: {racketMoveSpeed}");
        GetRacketSpeed((int)racketMoveSpeed);
        return;
        // Do I need a return here?
        //player2Script.UpdateSpeed(50);
    }

    public void DifficultyUpdateMedium()
    {
        racketMoveSpeed = 44;
        //Debug.Log($"Medium mode, racketMoveSpeed: {racketMoveSpeed}");
        GetRacketSpeed((int)racketMoveSpeed);
        return;
    }
    public void DifficultyUpdateHard()
    {
        racketMoveSpeed = 0;
        //Debug.Log($"Hard mode, racketMoveSpeed: {racketMoveSpeed}");
        GetRacketSpeed((int)racketMoveSpeed);
        return;
    }
    public int GetRacketSpeed(int value)
    {
        PlayerPrefs.SetInt("Racket Move Speed", racketMoveSpeed);
        Debug.Log($"racketMoveSpeed: {racketMoveSpeed}");
        Update();
        return racketMoveSpeed;
    }
    void Update() // removed private
    {
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) < 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * racketMoveSpeed ;
                Debug.Log("Testing speed:" + racketMoveSpeed);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * racketMoveSpeed ;
                Debug.Log("Testing speed:" + racketMoveSpeed);
            }
        }
        else
        {
            int yRandom = Random.Range(0, 10);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, yRandom) * racketMoveSpeed;
            //// Don't need an x value because locked into x-axis.
        }
    }
}
