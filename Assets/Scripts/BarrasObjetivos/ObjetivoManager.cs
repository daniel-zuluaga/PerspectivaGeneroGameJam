using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjetivoManager : MonoBehaviour
{
    public Objetivos[] objetivosScriptObjects;
    public Image[] objetivosImageBarra;
    public TextMeshProUGUI[] objetivosTextBarra;

    public float objetivoBarraValueMaxima;

    private void Update()
    {
        UpdateBarraObjetivos();
    }

    public void UpdateBarraObjetivos()
    {
        for (int i = 0; i < objetivosScriptObjects.Length; i++)
        {
            objetivosImageBarra[i].fillAmount = objetivosScriptObjects[i].valueBarraObjetivo / objetivoBarraValueMaxima;
            float porcentaje = objetivosScriptObjects[i].valueBarraObjetivo / objetivoBarraValueMaxima * 100;
            objetivosTextBarra[i].text = "" + porcentaje.ToString() + "%";
        }
    }
}
