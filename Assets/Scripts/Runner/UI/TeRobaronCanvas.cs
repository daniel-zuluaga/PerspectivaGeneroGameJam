using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeRobaronCanvas : MonoBehaviour
{
    public TextMeshProUGUI pointsRobadosValue;
    public Objetivos objetivoSumaInseguridad;
    public Objetivos objetivoRestaSeguridad;

    private float pointSumarORestar = 10;
    public bool dataAdd = false;

    private void Update()
    {
        pointsRobadosValue.color = Color.red;
        pointsRobadosValue.text = RunnerManager.instanceRunnerManager.pointPlayer.ToString();
        if (!dataAdd)
        {
            dataAdd = true;
            if(objetivoRestaSeguridad.valueBarraObjetivo < pointSumarORestar)
            {
                objetivoRestaSeguridad.valueBarraObjetivo = 0;
            }
            else
            {
                objetivoRestaSeguridad.valueBarraObjetivo -= pointSumarORestar;
            }
            objetivoSumaInseguridad.valueBarraObjetivo += pointSumarORestar;
        }
    }
}
