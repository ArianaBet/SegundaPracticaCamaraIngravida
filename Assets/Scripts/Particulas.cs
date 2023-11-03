using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
   

 [SerializeField] ParticleSystem ps;

    [SerializeField]
    GameObject jugador;

    [SerializeField]
    GameObject coin;

    [SerializeField]
    GameObject coin1;

    [SerializeField]
    GameObject coin2;

    [SerializeField]
    GameObject coin3;

    [SerializeField]
    GameObject coin4;

    [SerializeField]
    GameObject coin5;

    [SerializeField]
    GameObject coin6;

    [SerializeField]
    GameObject coin7;
    [SerializeField]
    GameObject coin8;


    int count;
    bool ps_status;
    void Start()
    {
        ps.Stop();
        ps = GameObject.Find("Particles").GetComponent<ParticleSystem>();
       
        
        count = 0;
    } // end of Start()
    void Update() // Time.fixedTime is set to its default-value (0.02s)
    {

         if ( ps_status == true) 
        {
           
            count = count + 1;
           if (count % 200 == 0)
            {
                ps_status = false;
                if (ps_status == false) ps.Pause(); ps.Clear();
                
            }
          
        }
         
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            ps.transform.position = coin.transform.position;
            ps.Play();
            ps_status = true;
           
        }
        if (other.gameObject.tag == "Coin1")
        {
            ps.transform.position = coin1.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin2")
        {
            ps.transform.position = coin2.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin3")
        {
            ps.transform.position = coin3.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin4")
        {
            ps.transform.position = coin4.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin5")
        {
            ps.transform.position = coin5.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin6")
        {
            ps.transform.position = coin6.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin7")
        {
            ps.transform.position = coin7.transform.position;
            ps.Play();
            ps_status = true;

        }
        if (other.gameObject.tag == "Coin8")
        {
            ps.transform.position = coin8.transform.position;
            ps.Play();
            ps_status = true;

        }


    }
}