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
            gameObject.GetComponent<ScrollGanar>().notMove = true;
            canvasGanador.SetActive(true);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
