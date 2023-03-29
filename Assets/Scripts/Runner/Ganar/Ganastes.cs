using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganastes : MonoBehaviour
{
    public GameObject canvasGanador;
    public Objetivos objetivoSeguridadSuma;
    public Objetivos objetivoRestaInseguridad;
    private float pointSumarORestar = 10;
    public bool addData = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            gameObject.GetComponent<ScrollGanar>().notMove = true;
            canvasGanador.SetActive(true);
            UIManager.instanceRunnerManager.AddPoint(RunnerManager.instanceRunnerManager.pointPlayer);
            if (!addData)
            {
                addData = true;
                if (objetivoRestaInseguridad.valueBarraObjetivo < pointSumarORestar)
                {
                    objetivoRestaInseguridad.valueBarraObjetivo = 0;
                }
                else
                {
                    objetivoRestaInseguridad.valueBarraObjetivo -= pointSumarORestar;
                }
                objetivoSeguridadSuma.valueBarraObjetivo += 10;
            }
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
