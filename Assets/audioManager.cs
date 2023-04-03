using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static audioManager instanceAudioManager;

    public AudioSource audioSourceCoin;

    private void Awake()
    {
        instanceAudioManager = this;
    }
}
