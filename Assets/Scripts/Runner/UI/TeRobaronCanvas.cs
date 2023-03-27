using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeRobaronCanvas : MonoBehaviour
{
    public TextMeshProUGUI pointsRobadosValue;

    private void Update()
    {
        pointsRobadosValue.color = Color.red;
        pointsRobadosValue.text = RunnerManager.instanceRunnerManager.pointPlayer.ToString();
    }
}
