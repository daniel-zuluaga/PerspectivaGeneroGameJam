using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GanasteCanvas : MonoBehaviour
{
    public TextMeshProUGUI pointsGanadosText;

    private void Update()
    {
        pointsGanadosText.color = Color.green;
        pointsGanadosText.text = RunnerManager.instanceRunnerManager.point.ToString();
        GameManager.instanceGameManager.AddPoint(RunnerManager.instanceRunnerManager.point);
    }
}
