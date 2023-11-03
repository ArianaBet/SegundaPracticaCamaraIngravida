using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Tiempo : MonoBehaviour
{
    [SerializeField] GameObject Enemigo;
    [SerializeField] int min, seg;
    [SerializeField] TextMeshProUGUI tiempo;
    [SerializeField] TextMeshProUGUI tiempofinal;
    private float restante;
    bool empezar;


    private void Start()
    {
       
    }
    private void Awake()
    {
        restante = (min * 60) + seg;
        if (empezar)
        {
            GetComponent<Tiempo>().enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

        restante += Time.deltaTime;
       
        int temmin = Mathf.FloorToInt(restante / 60);
        int temseg = Mathf.FloorToInt(restante % 60);
        tiempo.text = string.Format("{00:00} : {01:00}", temmin, temseg);
       tiempofinal.text = string.Format("{00:00} : {01:00}", temmin, temseg);

        if (GetComponent<Transform>().position.y < -10)
        {
            Destroy(this);
        }
        if (GetComponent<Contadordemonedas>().monedas == 9)
        {
            Destroy(this);
            Destroy(Enemigo);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
          
            
            Destroy(this);
            GetComponent<Movimientojugador>().enabled = false;
            empezar = false;

        }
        
    }
}
