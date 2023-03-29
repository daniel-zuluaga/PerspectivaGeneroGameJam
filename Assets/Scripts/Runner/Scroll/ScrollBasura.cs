using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBasura : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 4f;

    void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            if (!MovePlayerRunner.instanceMovePlayer.TeRobaron || !GameManager.instanceGameManager.ganaste && !MovePlayerRunner.instanceMovePlayer.scrollGanar.notMove)
            {
                transform.Translate(Vector2.left * scrollSpeed * Time.fixedDeltaTime);
            }
        }
    }
}
