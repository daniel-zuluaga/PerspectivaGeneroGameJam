using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 4f;

    void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            transform.Translate(Vector2.left * scrollSpeed * Time.fixedDeltaTime);
        }
    }
}
