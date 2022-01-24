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

        // ?. �� Instance�� null�� �ƴ� ��쿡�� Play�� ������, �ȵ� ��� C#�� ���� ������ �׳� .���� �ص� ��
    }
}