using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instanceGameManager;

    public float point;
    public bool ganaste = false;

    private void Awake()
    {
        instanceGameManager = this;
    }

    private void Update()
    {
        SiDiferentePointsRecoge();
    }

    public void SiDiferentePointsRecoge()
    {
        if(point != RunnerManager.instanceRunnerManager.point)
        {
            PlayerPrefs.SetFloat("MonedasPlayer", point);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Runner");
    }

    public void AddPoint(float amount)
    {
        point += amount;
    }
}
