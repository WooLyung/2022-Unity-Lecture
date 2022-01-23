using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectComponent : MonoBehaviour
{
    [SerializeField]
    AudioClip audio;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SoundManager.Instance?.Play(audio, SoundManager.SoundType.Effect);
    }
}
