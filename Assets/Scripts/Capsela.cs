using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Capsela : MonoBehaviour
{
    bool jugadordentro;
    private float t;

    //Movimiento
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public float velocidad = 10f;
    private void Start()
    {
        jugadordentro = false;

    }
    private void Update()
    {
        if( jugadordentro == false)
        {
            
            t = t + 1f * Time.deltaTime;
            transform.position = new Vector3(-6 * Mathf.Cos(t), transform.position.y, transform.position.z);
        }
        else
        {
            movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
            movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;

            transform.Translate(movimientoX, movimientoY, movimientoZ);
        }


    }
    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {

            Vector3 nuevaposición = new Vector3(7.83f, 2.33f, 18f);


            Vector3 irnuevaposición = Vector3.Lerp(transform.position, nuevaposición,velocidad * Time.deltaTime); //para no perder de vista al jugador


            transform.position = irnuevaposición; //cambio de posición
            jugadordentro = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            jugadordentro = true;
        }
    }
}
