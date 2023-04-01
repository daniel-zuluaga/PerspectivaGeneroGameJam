using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeRobaronCanvas : MonoBehaviour
{
    public TextMeshProUGUI pointsRobadosValue;
    public bool TengoData = false;

    private void Update()
    {
        pointsRobadosValue.color = Color.white;
        pointsRobadosValue.text = RunnerManager.instanceRunnerManager.pointPlayer.ToString();
        if (!TengoData)
        {
            TengoData = true;
            UIManager.instanceRunnerManager.AddPoint(RunnerManager.instanceRunnerManager.pointPlayer);
        }
    }
}
