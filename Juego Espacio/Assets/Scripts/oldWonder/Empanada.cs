using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empanada : MonoBehaviour
{

    public GameObject caracol;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Caracol")
        {
            print("Col");
            caracol.GetComponent<Animator>().SetBool("Toy_Muerto", true);
        }
    }


}
