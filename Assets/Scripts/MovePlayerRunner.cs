using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerRunner : MonoBehaviour
{
    [Header("Player Run")]
    public float speed;

    [Header("Player Run")]
    public float jumpForce;
    public bool canJump;

    public Rigidbody2D rb2D;


    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if (canJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rb2D.velocity = new Vector2(horizontal * speed, rb2D.velocity.y);
    }

    public void Jump()
    {
        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }
}
