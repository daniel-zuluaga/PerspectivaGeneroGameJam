using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBasura : MonoBehaviour
{
    [SerializeField] private GameObject[] basuraObstacle;
    [SerializeField] private float curwaitTimeCreateBasura = 2f;
    [SerializeField] private float waitTimeCreateBasura = 2f;

    private void FixedUpdate()
    {
        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            curwaitTimeCreateBasura -= Time.fixedDeltaTime;
            if(curwaitTimeCreateBasura <= 0)
            {
                StartCoroutine(SpawnObstacle());
                curwaitTimeCreateBasura = waitTimeCreateBasura;
            }
        }
    }

    private IEnumerator SpawnObstacle()
    {
        if(!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            int basuraRandom = Random.Range(0, basuraObstacle.Length);
            Instantiate(basuraObstacle[basuraRandom], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.2f);
        }
    }
}
