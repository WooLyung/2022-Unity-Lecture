using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    [SerializeField]
    AudioMixer mixer;

    void Start()
    {
        mixer.SetFloat("playerVol", -80.0f);
    }
}
