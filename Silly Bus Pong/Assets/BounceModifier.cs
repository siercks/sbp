using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceModifier : MonoBehaviour
{
    
    public BallMovement ballMovement;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        int hitCounter;
        float racketHeight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "TagPlayer1") // 
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHeight; // Should this go towards top or bottom?

        this.ballMovement.IncreaseHitCounter();
        // Debug.Log($"{hitCounter}");
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with Left Wall.");
        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with Right Wall.");

        }
    }

}
