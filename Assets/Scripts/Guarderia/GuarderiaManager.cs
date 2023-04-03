using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuarderiaManager : MonoBehaviour
{
    public static GuarderiaManager instanceGuarderiaManager;

    public int pointsGuarderia;

    public TextMeshProUGUI textGuarderia;

    private void Awake()
    {
        instanceGuarderiaManager = this;
    }

    private void FixedUpdate()
    {
        textGuarderia.text = "Puntos: " + pointsGuarderia.ToString();
    }

    public void AddPointsGuarderia(int amountGuarderia)
    {
        pointsGuarderia += amountGuarderia;
    }
}
