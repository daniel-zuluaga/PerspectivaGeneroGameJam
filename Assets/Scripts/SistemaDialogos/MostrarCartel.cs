using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarCartel : MonoBehaviour
{
    public InfoPlayer infoPlayer;
    public GameObject dialogos;
    public GameObject flechaPasarDialogo;

    public bool mostrarDialogoUnaVez = false;

    private void FixedUpdate()
    {
        VerificationMostrarCartelAlMejorar();
    }

    public void VerificationMostrarCartelAlMejorar()
    {
        if (!mostrarDialogoUnaVez)
        {
            if (!infoPlayer.yaComproProducto)
            {
                dialogos.SetActive(false);
                flechaPasarDialogo.SetActive(false);
            }
            else
            {
                dialogos.SetActive(true);
                flechaPasarDialogo.SetActive(true);
            }
            mostrarDialogoUnaVez = true;
        }
    }
}
