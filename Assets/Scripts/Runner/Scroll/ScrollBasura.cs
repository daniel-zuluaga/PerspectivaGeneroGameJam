using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBasura : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 4f;

    void Update()
    {
        if (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        }
    }
}
