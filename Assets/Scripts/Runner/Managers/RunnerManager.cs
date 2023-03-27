using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RunnerManager : MonoBehaviour
{
    public static RunnerManager instanceRunnerManager;

    public int pointPlayer;
    public TextMeshProUGUI textPoint;

    private void Awake()
    {
        instanceRunnerManager = this;
    }

    private void Start()
    {
        textPoint.text = "Basura: " + pointPlayer.ToString();
    }

    private void Update()
    {
        textPoint.text = "Basura: " + pointPlayer.ToString();
    }

    public void AddPointsRecogidos(int amount)
    {
        pointPlayer += amount;
    }
}
