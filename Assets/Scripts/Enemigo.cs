using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Enemigo : MonoBehaviour
{



    Vector3 Posici�nEne;
    public GameObject positionPlayer;
     bool perseguir;
     public float velocidad;
     int y;

     private void Start()
     {
         velocidad = 3.5f;
         perseguir = true;
     }
     private void Update()
     {
        
       
         Posici�nEne = transform.position;
      if (perseguir == true)
         {
             transform.position = Vector3.MoveTowards( Posici�nEne, positionPlayer.transform.position, velocidad * Time.deltaTime);
         }
      if (GetComponent<Transform>().position.y < -7)
         {
             transform.position = new Vector3 (9, 0.5f, -0.92f);
            perseguir = true;
         }

      if (GetComponent<Transform>().position.z < -5)
        {
            transform.position = new Vector3(9, 0.5f, -0.92f);
            perseguir = true;
        }
     

     }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this);
          
        }
    }


}
