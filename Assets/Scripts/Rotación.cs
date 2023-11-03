using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{

    [SerializeField]
    float rotacionY = 95;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f );
    }
}
