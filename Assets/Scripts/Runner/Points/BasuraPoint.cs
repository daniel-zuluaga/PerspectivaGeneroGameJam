using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraPoint : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            audioManager.instanceAudioManager.audioSourceCoin.Play();
            if (!MovePlayerRunner.instanceMovePlayer.chocasCarpincho && !GameManager.instanceGameManager.ganaste)
            {
                RunnerManager.instanceRunnerManager.AddPointsRecogidos(cantidadPuntos);
            }
            Destroy(gameObject);
        }
    }
}
