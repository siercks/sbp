using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedMultiplier;
    public float maxMoveSpeed;
    int hitCounter = 0;
    PlayerPrefs hitCounter1; // Put hitcounter and score as PlayerPrefs?
    float x, y;

    void Start()
    {
        StartCoroutine(StartBall());
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true) // A coroutine forces everything to wait for it, before actions happen.
    {
        hitCounter = 0;
        int xFun = Random.Range(1, 7);
        int yFun; // = Random.Range(-2, 2);
        if (Random.Range(0, 1) == 0)
        {
            yFun = Random.Range(1, 7);
        }
        else if (Random.Range(0, 1) == 1)
        {
            yFun = Random.Range(-1, -7);
        }
        yield return new WaitForSeconds(2); // Whenever start game is called, we wait two seconds.
        //Debug.Log($"xFun is {xFun}, yFun is {yFun}, hitCounter is {hitCounter}");
        if (isStartingPlayer1)
        {
            if (Random.Range(0, 1) == 0)
            {
                yFun = Random.Range(1, 7);
                MoveBall(new Vector2(-xFun, yFun));
                Debug.Log($"xFun is {xFun}, yFun is {yFun}, hitCounter is {hitCounter}");


            }
            else if (Random.Range(0, 1) == 1)
            {
                yFun = Random.Range(-1, -7);
                MoveBall(new Vector2(-xFun, yFun));
                Debug.Log($"xFun is {xFun}, yFun is {yFun}, hitCounter is {hitCounter}");

            }
        }
        else
        {
            if (Random.Range(0, 1) == 0)
            {
                yFun = Random.Range(1, 7);
                MoveBall(new Vector2(xFun, yFun));
                Debug.Log($"xFun is {xFun}, yFun is {yFun}, hitCounter is {hitCounter}");

            }
            else if (Random.Range(0, 1) == 1)
            {
                yFun = Random.Range(-1, -7);
                MoveBall(new Vector2(xFun, yFun));
                Debug.Log($"xFun is {xFun}, yFun is {yFun}, hitCounter is {hitCounter}");

            }
            //MoveBall(new Vector2(xFun, yFun));
        }
    } 
    public void PositionBall()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        gameObject.transform.position = new Vector3(0f, 0f, 0f);
        //StartBall();
        //StartCoroutine(StartBall());
        StopAllCoroutines();
        StartCoroutine(StartBall()); // Probably a better way to restart this ball. 
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.moveSpeed + (this.moveSpeedMultiplier * this.hitCounter);
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed; // Intellisense auto-completed the velocity formula!
    }
    public void IncreaseHitCounter()
    {
        if((this.hitCounter * this.moveSpeedMultiplier) <= this.maxMoveSpeed)
        {
            this.hitCounter++;
            Debug.Log($"{hitCounter}");
        }
    }
    public void RNGstart() // Can I better incorporate this somewhere?
    {
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        else if (Random.Range(0, 2) == 2)
        {
            x = 1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
        MoveBall(new Vector2(x, y));
    }
}
    
