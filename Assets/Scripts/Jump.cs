using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
   
    public float fuerza = 60f;

    Rigidbody jugador;
    bool suelo;

    private void Start()
    {
        jugador = GetComponent<Rigidbody>();
        bool suelo = true;
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && suelo)
        {
            jugador.AddForce(Vector3.up * fuerza, ForceMode.Impulse); //aplica fuerza hacia arriba
            suelo = false;
        }
       
            
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculos")
        {
            suelo = true;
        }
    }
        

}
