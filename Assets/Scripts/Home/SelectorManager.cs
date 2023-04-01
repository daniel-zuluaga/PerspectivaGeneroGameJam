using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorManager : MonoBehaviour
{
    public InfoPlayer infoPlayer;
    public Image imageChangeSprite;
    public Button buttonPlayGuarderia;

    public Sprite bloqueadoGuarderia;
    public Sprite desbloqueadaGuarderia;

    // Update is called once per frame
    void Update()
    {
        ValidateSiGanoRunner();
    }

    private void ValidateSiGanoRunner()
    {
        if (infoPlayer.yaGanastesRunner)
        {
            buttonPlayGuarderia.interactable = true;
            imageChangeSprite.sprite = desbloqueadaGuarderia;
        }
        else
        {
            buttonPlayGuarderia.interactable = false;
            imageChangeSprite.sprite = bloqueadoGuarderia;
        }
    }
}
