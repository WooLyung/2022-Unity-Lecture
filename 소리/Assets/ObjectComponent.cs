using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectComponent : MonoBehaviour
{
    public AudioClip audio;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SoundManager.Instance?.Play(audio, SoundManager.SoundType.SoundEffect);

        // ?. 는 Instance가 null이 아닐 경우에만 Play를 실행함, 안될 경우 C#의 버전 문제라서 그냥 .으로 해도 됨
    }
}