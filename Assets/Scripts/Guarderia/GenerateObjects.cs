using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjectsGuarderia;
    [SerializeField] private Transform[] positionsObjects;
    [SerializeField] private float curwaitTimeCreateObj = 2f;
    [SerializeField] private float waitTimeCreateObj = 2f;

    private void Update()
    {
        if (MovePlayer.instanceMovePlayer.ganas || MovePlayer.instanceMovePlayer.pierdes || MovePlayer.instanceMovePlayer.notMovePlayerGuarderia)
        {
            return;
        }
        else
        {
            curwaitTimeCreateObj -= Time.deltaTime;
            if (curwaitTimeCreateObj <= 0)
            {
                StartCoroutine(SpawnObstacle());
                curwaitTimeCreateObj = waitTimeCreateObj;
            }
        }
    }

    private IEnumerator SpawnObstacle()
    {
        int objectRandom = Random.Range(0, ObjectsGuarderia.Length);
        int transformRandom = Random.Range(0, ObjectsGuarderia.Length);

        Instantiate(ObjectsGuarderia[objectRandom], positionsObjects[transformRandom].position, Quaternion.identity);
        yield return new WaitForSeconds(.2f);
    }
}
