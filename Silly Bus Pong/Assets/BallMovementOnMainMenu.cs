using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementOnMainMenu : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedMultiplier;
    public float maxMoveSpeed;
    void Start()
    {
        StartCoroutine(StartBall());
    }
    public IEnumerator StartBall() // A coroutine forces everything to wait for it, before actions happen.
    {
        yield return new WaitForSeconds(2); // Whenever start game is called, we wait two seconds.
    }
 
    public void PositionBall()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        gameObject.transform.position = new Vector3(0f, 0f, 0f);
        MoveBall(new Vector2(1, 1));
        //StartBall();
        //StartCoroutine(StartBall());
        StopAllCoroutines();
        StartCoroutine(StartBall()); // Probably a better way to restart this ball. 
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.moveSpeed + (this.moveSpeedMultiplier * 1);
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed; // Intellisense auto-completed the velocity formula!
    }
}
