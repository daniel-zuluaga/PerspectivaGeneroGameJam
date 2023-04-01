using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New si tienes productos", menuName = "Ya tienes/Producto")]
public class YaTienesProducto : ScriptableObject
{
    public bool yaComproProducto;

    public YaTienesProducto()
    {
        yaComproProducto = false;
    }
}
