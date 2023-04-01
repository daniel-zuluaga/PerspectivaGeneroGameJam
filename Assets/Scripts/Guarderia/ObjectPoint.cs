using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoint : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            GuarderiaManager.instanceGuarderiaManager.AddPointsGuarderia(cantidadPuntos);
        }

        if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
            MovePlayer.instanceMovePlayer.life -= 1;
        }
    }
}
