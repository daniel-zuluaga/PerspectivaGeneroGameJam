using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour
{
    public GameObject[] objBackground;
    [SerializeField] private float curwaitTimeCreateBG = 2f;
    [SerializeField] private float waitTimeCreateBG = 2f;

    void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            curwaitTimeCreateBG -= Time.fixedDeltaTime;
            if(curwaitTimeCreateBG <= 0)
            {
                GenerateBackgroundParallax();
                curwaitTimeCreateBG = waitTimeCreateBG;
            }
        }
    }

    public void GenerateBackgroundParallax()
    {
        int basuraRandom = Random.Range(0, objBackground.Length);
        Instantiate(objBackground[basuraRandom], transform.position, Quaternion.identity);
    }
}
