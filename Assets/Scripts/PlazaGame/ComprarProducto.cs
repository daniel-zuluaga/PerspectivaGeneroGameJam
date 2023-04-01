using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Producto", menuName = "Comprar/Producto")]
public class ComprarProducto : ScriptableObject
{
    public string nameProducto;
    public int costProducto;
}
