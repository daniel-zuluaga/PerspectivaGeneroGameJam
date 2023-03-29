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
        spriteWidth = transform.gameObject.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            CheckTransformground();
        }
    }

    public void CheckTransformground()
    {
        if(transform.position.x < -spriteWidth)
        {
            transform.Translate(Vector2.right * 2f * spriteWidth );
        }
    }
}
