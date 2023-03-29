using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [Header("Count Down")]
    public GameObject ThreeCountDown;
    public GameObject TwoCountDown;
    public GameObject OneCountDown;
    public GameObject GOCountDown;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        MovePlayerRunner.instanceMovePlayer.notMovePlayer = true;
        yield return new WaitForSeconds(1.5f);
        ThreeCountDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        ThreeCountDown.SetActive(false);
        TwoCountDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        TwoCountDown.SetActive(false);
        OneCountDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        OneCountDown.SetActive(false);
        GOCountDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        GOCountDown.SetActive(false);
        MovePlayerRunner.instanceMovePlayer.notMovePlayer = false;
    }
}