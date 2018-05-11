using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruta : MonoBehaviour {

    public GameObject Puntos;

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        Puntos.SetActive(true);

        Puntaje.Puntos_Int += 50;
        
    }

    

    
}
