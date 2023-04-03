using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProductosManager : MonoBehaviour
{
    [Header("Scriptable Objects")]
    public ComprarProducto comprarProducto;
    public InfoPlayer moneyPlayerScripta;

    [Header("Text Producto")]
    public TextMeshProUGUI textName;
    public TextMeshProUGUI textCost;

    [Header("Objetos para Producto")]
    public GameObject buttonCost;
    public GameObject imageIluminada;
    public GameObject objPadreProducto;
    public AudioSource audioSourceBG;

    [Header("Audios Clip")]
    public AudioClip audioClipPlazaOscura;
    public AudioClip audioClipPlazaIluminada;

    private void Start()
    {
        textName.text = comprarProducto.nameProducto;

        if (!moneyPlayerScripta.yaComproProducto)
        {
            audioSourceBG.clip = audioClipPlazaOscura;
            audioSourceBG.Play();
        }
        else
        {
            audioSourceBG.clip = audioClipPlazaIluminada;
            audioSourceBG.Play();
        }
    }

    private void Update()
    {
        textCost.text = "$ " + comprarProducto.costProducto.ToString();
        if (!moneyPlayerScripta.yaComproProducto)
        {

            VerficarCompraProducto();
        }
        else
        {
            imageIluminada.SetActive(true);
            objPadreProducto.SetActive(false);
        }
    }

    public void VerficarCompraProducto()
    {
        if (comprarProducto.costProducto > moneyPlayerScripta.moneyPlayer)
        {
            textCost.color = Color.red;
            buttonCost.GetComponent<Button>().interactable = false;
            moneyPlayerScripta.yaComproProducto = false;
        }
        else
        {
            textCost.color = Color.white;
            buttonCost.GetComponent<Button>().interactable = true;
        }
    }

    public void ComprarProducto()
    {
        if (!moneyPlayerScripta.yaComproProducto)
        {
            moneyPlayerScripta.yaComproProducto = true;
            moneyPlayerScripta.moneyPlayer -= comprarProducto.costProducto;
            objPadreProducto.SetActive(false);
            imageIluminada.SetActive(true);
            audioSourceBG.clip = audioClipPlazaIluminada;
            audioSourceBG.Play();
        }
    }
}
