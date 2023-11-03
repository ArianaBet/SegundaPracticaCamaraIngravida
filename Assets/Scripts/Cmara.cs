using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmara : MonoBehaviour
{
    [SerializeField] GameObject capsula;
    bool camaraestatica;

    bool camaraestatica2;

    
    public Transform jugador;  // Referencia al transform del jugador
   
    public float velocidad = 10f;
    private bool seguir = false;

    private void Start()
    {
        transform.position = new Vector3(-0.25f, 18f, -10.5f);
        camaraestatica = true;
        seguir = false;

    }
    private void LateUpdate()
    {
        if (seguir)
        {
           
            Vector3 nuevaposición = jugador.position + new Vector3(0,5f,-7f); 

           
            //Vector3 suavizado1 = Vector3.MoveTowards(transform.position, nuevaposición , velocidad * Time.deltaTime); 
            //o
            Vector3 camaraquesigue = Vector3.Lerp(transform.position, nuevaposición, velocidad * Time.deltaTime); //para no perder de vista al jugador


            transform.position = camaraquesigue; //cambio de posición
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && jugador.transform.position.x <= 25)
        {
           camaraestatica = true;
           seguir = false;
           camaraestatica2 = false;
               
            
        }
       

        if (Input.GetKeyDown(KeyCode.C) && jugador.transform.position.x > 25)
        {
            camaraestatica = false;
            seguir = false;
            camaraestatica2 = true;
        }

        if (camaraestatica)
          {
            Vector3 posicionfija = new Vector3 (-0.25f, 18f, -10.5f);
            Vector3 posicióncamarafija = Vector3.MoveTowards(transform.position, posicionfija, 20* velocidad * Time.deltaTime);
            transform.position = posicióncamarafija;
          }
         if (camaraestatica2)
        {
            Vector3 posicionfija = new Vector3(45, 18f, 3f);
            Vector3 posicióncamarafija = Vector3.MoveTowards(transform.position, posicionfija, 20 * velocidad * Time.deltaTime);
            transform.position = posicióncamarafija;
        }

        
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            camaraestatica = false;
            seguir = true;
        } 

    }
}
