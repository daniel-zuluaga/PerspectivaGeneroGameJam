using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.chocasCarpincho && !GameManager.instanceGameManager.ganaste && !MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            offset = velocidadMovimiento * Time.fixedDeltaTime;
            material.mainTextureOffset += offset;
        }
    }
}
