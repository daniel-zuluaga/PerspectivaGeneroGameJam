using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraPoint : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
            {
                RunnerManager.instanceRunnerManager.AddPointsRecogidos(cantidadPuntos);
            }
            Destroy(gameObject);
        }
    }
}
