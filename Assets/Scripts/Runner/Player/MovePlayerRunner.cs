using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerRunner : MonoBehaviour
{
    public static MovePlayerRunner instanceMovePlayer;

    [Header("Player Jump")]
    public float jumpForce;
    public float cancelForceJump;
    public bool canJump;
    public bool TeRobaron = false;
    public float waitIncrementoSpeed;

    public float esperarAumentarVelocidad;
    public GameObject canvasOver;
    public Rigidbody2D rb2D;
    public ScrollGanar scrollGanar;
    public GameObject generarLadron;
    public bool notMovePlayer;

    private void Awake()
    {
        instanceMovePlayer = this;
    }

    private void Start()
    {
        TeRobaron = false;
        canvasOver.SetActive(false);
    }

    private void Update()
    {
        if (!TeRobaron && !notMovePlayer)
        {
            if (canJump == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    canJump = false;
                    Jump();
                }
            }
        }
    }

    public void Jump()
    {
        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ladron"))
        {
            generarLadron.GetComponent<BoxCollider2D>().enabled = false;
            scrollGanar.notMove = true;
            TeRobaron = true;
            canvasOver.SetActive(true);
        }
        canJump = true;
    }
}
