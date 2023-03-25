using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObstacle : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 4f;

    public float waitIncrementoSpeed;

    public float esperarAumentarVelocidad;

    void Update()
    {
        if (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            Aumentarvelocidad();
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        }
    }

    public void Aumentarvelocidad()
    {
        esperarAumentarVelocidad -= Time.deltaTime;
        if (esperarAumentarVelocidad < 0)
        {
            scrollSpeed += 1f;
            esperarAumentarVelocidad = waitIncrementoSpeed;
        }
    }
}
