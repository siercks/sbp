using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed = 200f;

    void Update()
    {
        //float moveAmount = Input.GetAxisRaw("Vertical1") * playerMoveSpeed; // Needed that 1 in there.
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAmount);
        DeltaTimeUpdate();
    }
    void DeltaTimeUpdate()
    {
        float moveAmount = Input.GetAxisRaw("Vertical1") * playerMoveSpeed; // Needed that 1 in there.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAmount);
    }
}
