using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObstacle : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 4f;
    [SerializeField] private ScrollGanar gameObjectGanar;
    [SerializeField] private float incrementarSpeed;

    public float waitIncrementoSpeed;

    public float esperarAumentarVelocidad;

    void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            if (!MovePlayerRunner.instanceMovePlayer.TeRobaron || !GameManager.instanceGameManager.ganaste && !MovePlayerRunner.instanceMovePlayer.scrollGanar.notMove)
            {
                Aumentarvelocidad();
                transform.Translate(Vector2.left * scrollSpeed * Time.fixedDeltaTime);
            }
        }
    }

    public void Aumentarvelocidad()
    {
        esperarAumentarVelocidad -= Time.deltaTime;
        if (esperarAumentarVelocidad <= 0)
        {
            scrollSpeed += incrementarSpeed;
            esperarAumentarVelocidad = waitIncrementoSpeed;
        }
    }
}
