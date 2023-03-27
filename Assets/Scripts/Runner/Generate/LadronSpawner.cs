using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ladronObstacle;
    [SerializeField] private GameObject ganarObj;
    [SerializeField] private float waitTimeCreateLadron = 2f;

    [SerializeField] private float waitTimeGanar = 60f;
    [SerializeField] private bool createObjGanar = false;

    private void Start()
    {
        if (waitTimeGanar > 0 && !createObjGanar)
        {
            StartCoroutine(SpawnObstacle());
        }
        ganarObj.SetActive(false);
    }

    private void Update()
    {
        if (MovePlayerRunner.instanceMovePlayer.TeRobaron || GameManager.instanceGameManager.ganaste || createObjGanar)
        {
            return;
        }

        waitTimeGanar -= Time.deltaTime;

        if(waitTimeGanar <= 0)
        {
            createObjGanar = true;
        }

        if (createObjGanar)
        {
            GanerateGanar();
            return;
        }
    }

    public void GanerateGanar()
    {
        if(!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            GameManager.instanceGameManager.ganaste = true;
            ganarObj.SetActive(true);
            ganarObj.transform.position = transform.position;
        }
    }

    private IEnumerator SpawnObstacle()
    {
        while (!MovePlayerRunner.instanceMovePlayer.TeRobaron && !GameManager.instanceGameManager.ganaste)
        {
            Instantiate(ladronObstacle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(waitTimeCreateLadron);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladron"))
        {
            Destroy(collision.gameObject);
        }
    }
}
