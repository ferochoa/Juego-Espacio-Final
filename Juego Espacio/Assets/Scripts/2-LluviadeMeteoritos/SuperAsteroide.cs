using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperAsteroide : MonoBehaviour {

    private GameObject target;
	private float[] asteroidSpeed;
	private int speedLevel;
	void Awake ()
    {
        target = GameObject.Find("target");
        Vector3 direction = Vector3.zero - target.transform.position;
        transform.LookAt(target.transform.position);
    }
	void Start()
	{
		asteroidSpeed = new float[4];
		asteroidSpeed [0] = 0.5f;
		asteroidSpeed [1] = 0.7f;
		asteroidSpeed [2] = 0.9f;
		asteroidSpeed [3] = 1f;
		speedLevel = Random.Range (0,4);
	}	
	void Update ()
    {		
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, asteroidSpeed[speedLevel]);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
