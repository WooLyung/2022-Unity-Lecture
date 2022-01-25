using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(Time.deltaTime, 0, 0);
    }
}
