using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketAI : MonoBehaviour
{
    public float racketMoveSpeed;
    public GameObject ball;
    ScoreManager scoreManager;
    private void Update()
    {
        //
        if (Mathf.Abs(transform.position.y - ball.transform.position.y) < 50)
        {
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, yRandom) * racketMoveSpeed;
            // Don't need an x value because locked into x-axis.
        }
        //if (scoreManager.GoalPlayer1() = true)
        //{
        // Trying to figure out how to reset racketAI to middle of screen so it stops glitching out.
        //}
    }
}
