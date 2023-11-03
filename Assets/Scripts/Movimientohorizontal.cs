using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientohorizontal : MonoBehaviour
{
   private float t;
    private void Update()
    {
        t = t + 1f * Time.deltaTime;
        transform.position = new Vector3(-6 * Mathf.Cos(t), transform.position.y, transform.position.z);
    }
}
