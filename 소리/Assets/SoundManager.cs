using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public enum SoundType
    {
        BGM = 0,
        Effect = 1
    }

    public static SoundManager Instance { get; private set; } = null;

    [SerializeField]
    AudioSource[] sources = new AudioSource[0];

    void Start()
    {
        Instance = this;
    }

    public void Play(AudioClip audio, SoundType type, float pitch = 1.0f, float volume = 1.0f)
    {
        AudioSource source = sources[(int)type];

        if (source)
        {
            source.pitch = pitch;
            source.volume = volume;

            if (type == SoundType.BGM)
            {
                if (source.isPlaying)
                    source.Stop();
                source.clip = audio;
                source.Play();
            }
            else
            {
                source.PlayOneShot(audio);
            }
        }
    }
}