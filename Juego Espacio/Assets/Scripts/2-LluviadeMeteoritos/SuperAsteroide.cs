using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperAsteroide : MonoBehaviour {

    private GameObject target;
	void Awake ()
    {
        target = GameObject.Find("target");
        Vector3 direction = Vector3.zero - target.transform.position;
        transform.LookAt(target.transform.position);
    }
	
	
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1f);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
