using UnityEngine;
using System.Collections;

public class direccion : MonoBehaviour {

    float scaleX;
    private float tiempoActual;

    public GameObject prefab1,prefab2;
    public float tiempo;
    int Aux = 0;

    void Start () {
        scaleX = transform.localScale.x;
	}

    void Update()
    {

        tiempoActual += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            transform.localScale = new Vector3(-scaleX, transform.localScale.y);
            Aux = 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y);
            Aux = 2;
        }
           
        if (tiempoActual >= tiempo)
        {

            if(Aux == 1)
            {
                 if (Input.GetKeyDown(KeyCode.Space))
                {
                tiempoActual = 0;
                Instantiate(prefab1, transform.position, transform.rotation);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    tiempoActual = 0;
                    Instantiate(prefab2, transform.position, transform.rotation);
                }

            }

        }
    }
}
