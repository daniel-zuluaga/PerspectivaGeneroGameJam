using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorManager : MonoBehaviour
{
    public string scenePlazaObscuraDialogo;
    public string scenePlazaIluminadaDialogo;
    public InfoPlayer infoPlayer;

    public void VerificarSiMejoraLaPlaza()
    {
        if (!infoPlayer.yaComproProducto)
        {
            SceneManager.LoadScene(scenePlazaObscuraDialogo);
        }
        else
        {
            SceneManager.LoadScene(scenePlazaIluminadaDialogo);
        }
    }
}
