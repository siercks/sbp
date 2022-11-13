using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{
    //public float playerMovementSpeed;
    [SerializeField] float playerMoveSpeed = 1f;

    public void Update()
    {
        float moveAmount = Input.GetAxisRaw("Vertical1"); // Needed that 1 in there.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAmount) * playerMoveSpeed;


    }

}
