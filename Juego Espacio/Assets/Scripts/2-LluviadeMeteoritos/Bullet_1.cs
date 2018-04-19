using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_1 : MonoBehaviour {

	private Rigidbody rb;
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		//addForce ();
	}	

	void Update () {
		
	}
	void addForce()
	{
		rb.AddForce (Vector3.up * 50, ForceMode.Impulse);
	}
}
