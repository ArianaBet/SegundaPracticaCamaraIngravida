using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
   
    private bool objetoDesapareciendo = false;
    private float segDesaparicion = 2.0f; // segundos que tarda en desaparecer
    private float segTranscurrido = 0.0f;
    private Vector3 escalaInicial;
    private Vector3 escalaFinal = Vector3.zero;
    float velocidad = 12f;

    void Start()
    {
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        if (objetoDesapareciendo == true)
        {
            segTranscurrido += Time.deltaTime;

            
            float seg = segTranscurrido / segDesaparicion; //lo que tarda en desaparecer
            transform.localScale = Vector3.Lerp(escalaInicial, escalaFinal, seg); //para que se escale suavemente

            if (segTranscurrido >= segDesaparicion)
            {
               
                objetoDesapareciendo = false;
                gameObject.SetActive(false); // para que desaparezca
               
            }
        }
       
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("Player"))
        {
           
            transform.localScale = escalaInicial;
            objetoDesapareciendo = true;
            gameObject.SetActive(true);
        }
    }
}

   
   

