using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RunnerManager : MonoBehaviour
{
    public static RunnerManager instanceRunnerManager;

    public float point;
    public TextMeshProUGUI textPoint;

    private void Awake()
    {
        instanceRunnerManager = this;
    }

    private void Start()
    {
        textPoint.text = "Points: " + point.ToString();
    }

    private void Update()
    {
        textPoint.text = "Points: " + point.ToString();
    }
}
