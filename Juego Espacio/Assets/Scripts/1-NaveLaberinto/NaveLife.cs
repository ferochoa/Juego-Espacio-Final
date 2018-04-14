using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NaveLife : MonoBehaviour {

    int vida = 4;

    public GameObject[] estrellas;

    public Sprite estrellaInactiva;

    void EstrellaMuerta()
    {
        estrellas[vida].GetComponent<Image>().sprite = estrellaInactiva;
        estrellas[vida].GetComponent<Animator>().SetBool("Titilar", true);
        StartCoroutine(TitilaStop(vida));
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "bullet")
        {
            EstrellaMuerta();
            vida--;        
        }
    }

    IEnumerator TitilaStop(int Vida)
    {
        yield return new WaitForSeconds(0.5f);

        estrellas[Vida].GetComponent<Animator>().SetBool("Titilar", false);
    }
}
