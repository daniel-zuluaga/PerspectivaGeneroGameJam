using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float offsetX;

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.position = new Vector2(target.transform.position.x + offsetX, transform.position.y);
        }
    }
}
