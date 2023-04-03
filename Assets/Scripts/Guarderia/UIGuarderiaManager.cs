using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGuarderiaManager : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject ganasCanvas;

    public SpriteRenderer imageBG;
    public Sprite spriteFinalizadoGuarderia;

    public AudioSource audioSourceGameOver;
    public AudioSource audioSourceBG;

    private void Start()
    {
        gameOver.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (MovePlayer.instanceMovePlayer.ganas || MovePlayer.instanceMovePlayer.pierdes || MovePlayer.instanceMovePlayer.notMovePlayerGuarderia)
        {
            return;
        }
        else
        {
            UpdateHearts();

            if (MovePlayer.instanceMovePlayer.life == 0)
            {
                ActiveGameOver();
            }

            if (GuarderiaManager.instanceGuarderiaManager.pointsGuarderia >= 20)
            {
                ActiveGanarCanvas();
            }
        }
    }

    public void UpdateHearts()
    {
        switch (MovePlayer.instanceMovePlayer.life)
        {
            case 0:
                StartCoroutine(AnimHeart(hearts, 0));
                break;
            case 1:
                StartCoroutine(AnimHeart(hearts, 1));
                break;
            case 2:
                StartCoroutine(AnimHeart(hearts, 2));
                break;
        }
    }

    IEnumerator AnimHeart(GameObject[] objHeart, int indexObjHeart)
    {
        objHeart[indexObjHeart].GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        objHeart[indexObjHeart].SetActive(false);
    }

    public void ActiveGameOver()
    {
        audioSourceGameOver.Play();
        audioSourceBG.Stop();
        MovePlayer.instanceMovePlayer.gameObject.SetActive(false);
        MovePlayer.instanceMovePlayer.pierdes = true;
        GuarderiaManager.instanceGuarderiaManager.textGuarderia.gameObject.SetActive(false);
        gameOver.SetActive(true);
    }

    public void ActiveGanarCanvas()
    {
        imageBG.sprite = spriteFinalizadoGuarderia;
        imageBG.color = Color.white;
        MovePlayer.instanceMovePlayer.ganas = true;
        GuarderiaManager.instanceGuarderiaManager.textGuarderia.gameObject.SetActive(false);
        StartCoroutine(WaitActiveGanar());
    }

    IEnumerator WaitActiveGanar()
    {
        yield return new WaitForSeconds(1.5f);
        ganasCanvas.SetActive(true);
    }
}
