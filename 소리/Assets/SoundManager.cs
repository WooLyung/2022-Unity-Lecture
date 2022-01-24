using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public enum SoundType
    {
        BGM = 0,
        SoundEffect = 1
    }

    public AudioSource[] sources = new AudioSource[0];

    public static SoundManager Instance // ������ �̱��� ����
    {
        get; // �ܺο��� SoundManager.Instance�� ���� �޾ƿ� �� ����
        private set; // �ܺο��� SoundManager.Instance�� ���� ������ ���� ����
    } = null; // SoundManager.Instance �� �⺻���� null

    void Start()
    {
        Instance = this;
    }

    public void Play(AudioClip audio, SoundType type, float pitch = 1.0f, float volume = 1.0f)
    {
        AudioSource source = sources[(int)type]; // BGM�̶�� 0�� �ε���, SoundEffect��� 1�� �ε���

        if (source != null)
        {
            source.pitch = pitch;
            source.volume = volume;

            if (type == SoundType.BGM) // BGM�� ������� BGM�� ���߰� BGM ������ �ٲ� ������ �����
            {
                if (source.isPlaying)
                    source.Stop();
                source.clip = audio;
                source.Play();
            }
            else
            {
                source.PlayOneShot(audio); // ������� �ٷ� 1���� �����Ŵ
            }
        }
    }
}
