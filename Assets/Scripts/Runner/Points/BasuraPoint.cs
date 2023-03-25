using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RunnerManager.instanceRunnerManager.point += 1;
            Destroy(gameObject);
        }
    }
}
