using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instanceGameManager;

    public bool ganaste = false;

    private void Awake()
    {
        instanceGameManager = this;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Runner");
    }
}
