using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
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
        MovePlayer.instanceMovePlayer.notMovePlayerGuarderia = true;
        yield return new WaitForSeconds(1f);
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
        MovePlayer.instanceMovePlayer.notMovePlayerGuarderia = false;
    }
}
