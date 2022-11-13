using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed = 200f;
    
    public void Update()
    {
        float moveAmount = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0, moveAmount) * playerMoveSpeed;
    }
}
