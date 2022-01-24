using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // « ø‰«‘

public class SetVolume2 : MonoBehaviour
{
    public AudioMixer mixer;

    void Start()
    {
        mixer.SetFloat("EffectVol", -80.0f);
    }
}
