using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosonidoMonedas : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip sonidomoneda;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin1"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin2"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin3"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin4"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin5"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin6"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
        if (other.CompareTag("Coin7"))
        {
            audioSource.PlayOneShot(sonidomoneda);

        }
    }
}
