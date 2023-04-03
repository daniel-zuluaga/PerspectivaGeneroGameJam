using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaDislogos2 : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject flechaPasarLinea;

    public string[] lines;

    public float textSpeed = 0.1f;

    private int index;

    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    public void PasarSiguienteLinea()
    {
        if (dialogueText.text == lines[index])
        {
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = lines[index];
        }
    }

    public void StartDialogue()
    {
        index = 0;

        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        yield return new WaitForSeconds(0.3f);

        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;

            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLines()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            gameObject.SetActive(false);
            flechaPasarLinea.SetActive(false);
        }
    }
}
