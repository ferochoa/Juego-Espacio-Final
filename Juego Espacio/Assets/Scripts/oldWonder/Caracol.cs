using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracol : MonoBehaviour {

    public Transform Personaje;

    float Distancia;
    public float Min_Dist;
	
	void Start () {
		
	}
	
	
	void Update ()
    {
        Distancia = Vector3.Distance(transform.position, Personaje.position);

        if(Distancia < Min_Dist)
        {
            GetComponent<Animator>().SetBool("Ta_Cerca", true);
        }

        else
        {
            GetComponent<Animator>().SetBool("Ta_Cerca", false);
        }
	}

    
}
