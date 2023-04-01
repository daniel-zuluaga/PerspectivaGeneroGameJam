using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceBG;

    void Awake()
    {
        if (audioSourceBG != null)
        {
            audioSourceBG.Play();
        }
    }
}
