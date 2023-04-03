using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ladronObstacle;
    [SerializeField] private GameObject ganarObj;
    [SerializeField] private float curWaitTimeCreateLadron = 2f;
    [SerializeField] private float waitTimeCreateLadron = 2f;

    [SerializeField] private float waitTimeGanar = 60f;
    [SerializeField] private bool createObjGanar = false;

    private void Start()
    {
        ganarObj.SetActive(false);
    }

    private void FixedUpdate()
    {
        VerificarSiGenera();
    }

    public void VerificarSiGenera()
    {
        if (MovePlayerRunner.instanceMovePlayer.chocasCarpincho || GameManager.instanceGameManager.ganaste || createObjGanar || MovePlayerRunner.instanceMovePlayer.scrollGanar.notMove)
        {
            return;
        }

        if (!MovePlayerRunner.instanceMovePlayer.notMovePlayer)
        {
            waitTimeGanar -= Time.fixedDeltaTime;
            curWaitTimeCreateLadron -= Time.fixedDeltaTime;

            if (curWaitTimeCreateLadron <= 0 && waitTimeGanar > 0 && !createObjGanar)
            {
                StartCoroutine(SpawnObstacle());
                curWaitTimeCreateLadron = waitTimeCreateLadron;
            }

            if (waitTimeGanar <= 0)
            {
                createObjGanar = true;
            }

            if (createObjGanar)
            {
                GanerateGanar();
                return;
            }
        }
    }

    public void GanerateGanar()
    {
        if(!MovePlayerRunner.instanceMovePlayer.chocasCarpincho && !GameManager.instanceGameManager.ganaste)
        {
            ganarObj.SetActive(true);
            ganarObj.transform.position = transform.position;
        }
    }

    private IEnumerator SpawnObstacle()
    {
        if(!MovePlayerRunner.instanceMovePlayer.chocasCarpincho && !GameManager.instanceGameManager.ganaste)
        {
            Instantiate(ladronObstacle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(.2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Carpincho"))
        {
            Destroy(collision.gameObject);
        }
    }
}
