using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedMultiplier;
    public float maxMoveSpeed;
    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(StartBall());
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true) // A coroutine forces everything to wait for it, before actions happen.
    {
        hitCounter = 0;
        yield return new WaitForSeconds(2); // Whenever start game is called, we wait two seconds.
        if (isStartingPlayer1)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    } 
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = moveSpeed + moveSpeedMultiplier * hitCounter;
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed; // Intellisense auto-completed the velocity formula!
    }
    public void IncreaseHitCounter()
    {
        if(hitCounter * moveSpeedMultiplier <= maxMoveSpeed)
        {
            hitCounter++;
        }
    }
}
    
