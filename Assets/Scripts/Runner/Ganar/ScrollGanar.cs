using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGanar : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 2f;
    public bool notMove = false;

    void Update()
    {
        if (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste || !notMove)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
        }
    }
}
