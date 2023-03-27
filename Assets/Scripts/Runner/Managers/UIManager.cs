using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instanceRunnerManager;

    public MoneyPlayer pointPlayer;
    public TextMeshProUGUI textPoint;

    private void Awake()
    {
        instanceRunnerManager = this;
    }

    private void Start()
    {
        textPoint.text = "Plata: " + pointPlayer.moneyPlayer.ToString();
    }

    private void Update()
    {
        textPoint.text = "Plata: " + pointPlayer.moneyPlayer.ToString();
    }

    public void AddPoint(int amount)
    {
        pointPlayer.moneyPlayer += amount;
    }
}
