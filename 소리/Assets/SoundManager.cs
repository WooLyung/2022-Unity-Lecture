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

    public static SoundManager Instance // 간단한 싱글톤 패턴
    {
        get; // 외부에서 SoundManager.Instance로 값을 받아올 수 있음
        private set; // 외부에서 SoundManager.Instance의 값을 수정할 수는 없음
    } = null; // SoundManager.Instance 의 기본값은 null

    void Start()
    {
        Instance = this;
    }

    public void Play(AudioClip audio, SoundType type, float pitch = 1.0f, float volume = 1.0f)
    {
        AudioSource source = sources[(int)type]; // BGM이라면 0번 인덱스, SoundEffect라면 1번 인덱스

        if (source != null)
        {
            source.pitch = pitch;
            source.volume = volume;

            if (type == SoundType.BGM) // BGM은 재생중인 BGM을 멈추고 BGM 파일을 바꾼 다음에 재생함
            {
                if (source.isPlaying)
                    source.Stop();
                source.clip = audio;
                source.Play();
            }
            else
            {
                source.PlayOneShot(audio); // 오디오를 바로 1번만 재생시킴
            }
        }
    }
}
