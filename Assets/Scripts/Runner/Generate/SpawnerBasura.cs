using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBasura : MonoBehaviour
{
    [SerializeField] private GameObject basuraObstacle;
    [SerializeField] private float waitTimeCreateBasura = 2f;

    private void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    private void Update()
    {
        if (MovePlayerRunner.instanceMovePlayer.TeRobaron || GameManager.instanceGameManager.ganaste)
        {
            return;
        }
    }

    private IEnumerator SpawnObstacle()
    {
        while (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            Instantiate(basuraObstacle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(waitTimeCreateBasura);
        }
    }
}
