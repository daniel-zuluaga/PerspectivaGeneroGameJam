using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GanasteCanvas : MonoBehaviour
{
    public TextMeshProUGUI pointsRobadosValue;
    public bool addData = false;

    private void Update()
    {
        pointsRobadosValue.color = Color.green;
        pointsRobadosValue.text = RunnerManager.instanceRunnerManager.pointPlayer.ToString();

        if (!addData)
        {
            addData = true;
        }
    }
}
