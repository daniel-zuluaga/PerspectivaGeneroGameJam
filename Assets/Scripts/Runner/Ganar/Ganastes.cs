using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganastes : MonoBehaviour
{
    public GameObject canvasGanador;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            canvasGanador.SetActive(true);
        }
    }
}
