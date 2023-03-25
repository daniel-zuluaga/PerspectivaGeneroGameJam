using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeat : MonoBehaviour
{
    private float spriteWidth;

    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
        spriteWidth = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTransformground();
    }

    public void CheckTransformground()
    {
        if(transform.position.x < -spriteWidth)
        {
            transform.Translate(Vector2.right * 2f * spriteWidth);
        }
    }
}
