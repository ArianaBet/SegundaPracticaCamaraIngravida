using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Contadordemonedas : MonoBehaviour
{
    [SerializeField] GameObject Capsula;
    [SerializeField] GameObject Plataforma;
    public int monedas;
    [SerializeField]
    TextMeshProUGUI Coin;
    [SerializeField] GameObject pantallafinal;
    [SerializeField] GameObject tiempo;
    [SerializeField] GameObject siguientenivel;

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
        Capsula.SetActive(false);
        Plataforma.SetActive(false);
        siguientenivel.SetActive(false);
    }
    private void Update()
    {
        if ( monedas == 8)
       {
               Capsula.SetActive(true);
            Plataforma.SetActive(true);
                siguientenivel.SetActive(true);
        }
       
        if (monedas == 9)
        {
                tiempo.SetActive(true);
                GetComponent<Movimientojugador>().enabled = false;
                pantallafinal.SetActive(true);
           
             
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;
           
         }

        if (other.gameObject.tag == "Coin1")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin2")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin3")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin4")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin5")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin6")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin7")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin8")
        {
            monedas = monedas + 1;
            Coin.text = "0" + monedas;
        }

    }
   
   
}
