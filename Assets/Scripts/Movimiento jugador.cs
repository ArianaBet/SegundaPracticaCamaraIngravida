using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movimientojugador : MonoBehaviour
{

    [SerializeField]
    GameObject capsula;
    //Pantalla de derrota


    [SerializeField]
    GameObject pantalladerrota;
    [SerializeField]
    GameObject tecaiste;

    //Movimiento
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public float velocidad = 0f;

    //musica de monedas
    private AudioSource monedas;

    public bool isInsideCapsule;
    private void Start()
    {
       monedas = GetComponent<AudioSource>();
        GetComponent<Rigidbody>().useGravity = true;
        isInsideCapsule = false;

    }
    void Update()
    {
        if (isInsideCapsule == true)
        {
            GetComponent<Rigidbody>().useGravity = false;

            Vector3 nuevaposición = capsula.transform.position;


           
            Vector3 jugadorsiguecapsula= Vector3.Lerp(transform.position, nuevaposición, 10 * velocidad * Time.deltaTime); //para no perder de vista al jugador


            transform.position = jugadorsiguecapsula; //cambio de posición

        }

        if (isInsideCapsule == false)
        {
            GetComponent<Rigidbody>().useGravity = true;
            movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
      
        transform.Translate(movimientoX, movimientoY, movimientoZ);
        }
       
        if (Input.GetKey(KeyCode.X))
        {
            isInsideCapsule = false;
        }
        
       // si se cae
       if (gameObject.GetComponent<Transform>().position.y < -10)
        {
          tecaiste.SetActive(true);
        }

       

       
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            pantalladerrota.SetActive(true);
            GetComponent<Movimientojugador>().enabled = false;
         
        }
        if (collision.gameObject.tag == "Coin")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin1")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin2")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin3")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin4")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin5")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin6")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin7")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin8")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Capsula")
        {
            EnterCapsule();
            transform.position = capsula.transform.position;
        }
        void EnterCapsule()
        {
            isInsideCapsule = true;
        }
    }
   
}
