using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGround : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 8f;

    void Update()
    {
        if (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        }
    }
}