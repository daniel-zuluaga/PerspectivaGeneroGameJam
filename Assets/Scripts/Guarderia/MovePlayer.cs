using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    public static MovePlayer instanceMovePlayer;

    public int life = 3;

    public Rigidbody2D rig;

    public bool ganas;
    public bool pierdes;
    public bool notMovePlayerGuarderia;

    private void Awake()
    {
        instanceMovePlayer = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        if (ganas || pierdes || notMovePlayerGuarderia)
        {
            return;
        }
        else
        {
            float velocidadInput = Input.GetAxisRaw("Horizontal");

            rig.velocity = new Vector2(velocidadInput * speed, rig.velocity.y);
        }
    }
}
