using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ladronObstacle;
    [SerializeField] private GameObject ganarObj;
    [SerializeField] private float waitTimeCreateLadron = 2f;

    [SerializeField] private float waitTimeGanar = 60f;

    private void Start()
    {
        if (MovePlayerRunner.instanceMovePlayer.TeRobaron && GameManager.instanceGameManager.ganaste)
        {
            return;
        }
        if (waitTimeGanar > 0)
        {
            StartCoroutine(SpawnObstacle());
        }
        else if(waitTimeGanar <= 0)
        {
            GanerateGanar();
        }
        return;
    }

    private void Update()
    {
        waitTimeGanar -= Time.deltaTime;
    }

    public void GanerateGanar()
    {
        GameManager.instanceGameManager.ganaste = true;
        Instantiate(ganarObj, transform.position, Quaternion.identity);
    }

    private IEnumerator SpawnObstacle()
    {
        if(MovePlayerRunner.instanceMovePlayer.TeRobaron && GameManager.instanceGameManager.ganaste)
        {
            yield return new WaitForSeconds(.5f);
        }

        while (true)
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
