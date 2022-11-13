using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceModifier : MonoBehaviour
{
    
    public BallMovement ballMovement;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        float racketHeight = c.collider.bounds.size.y;
        float x;
        float y = (ballPosition.y - racketPosition.y) / racketHeight; // Should this go towards top or bottom?
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            
        }
        else if (collision.gameObject.name == "WallRight")
        {

        }
    }

}
