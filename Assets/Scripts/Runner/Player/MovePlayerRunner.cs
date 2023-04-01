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
    public bool chocasCarpincho = false;
    public float waitIncrementoSpeed;

    public float esperarAumentarVelocidad;
    public GameObject canvasOver;
    public Rigidbody2D rb2D;
    public ScrollGanar scrollGanar;
    public GameObject generarLadron;
    public bool notMovePlayer;
    public bool canData = false;

    public Animator anim;

    private void Awake()
    {
        instanceMovePlayer = this;
    }

    private void Start()
    {
        chocasCarpincho = false;
        canvasOver.SetActive(false);
    }

    private void Update()
    {
        if (notMovePlayer || chocasCarpincho || GameManager.instanceGameManager.ganaste)
        {
            anim.Play("IdleAnim");
        }
        
        if (!chocasCarpincho && !notMovePlayer)
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isJumping", false);
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
        anim.SetBool("isJumping", true);
        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Carpincho"))
        {
            generarLadron.GetComponent<BoxCollider2D>().enabled = false;
            scrollGanar.notMove = true;
            chocasCarpincho = true;
            canvasOver.SetActive(true);
            if (!canData)
            {
                UIManager.instanceRunnerManager.AddPoint(RunnerManager.instanceRunnerManager.pointPlayer);
                canData = true;
            }
        }
        canJump = true;
    }
}
