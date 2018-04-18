﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	[SerializeField]
	private float lifeTime, force;
	private Vector2 forceVector;

	void Start()
	{
		Invoke ("destroy", lifeTime);
		if (this.gameObject.tag == "left spawn")
			forceVector = new Vector2 (Random.Range(3,8),-2);
		if (this.gameObject.tag == "right spawn")
			forceVector = new Vector2 (Random.Range(-7,-2), -2);
		
		addForce ();
	}

	private void destroy()
	{
		Destroy (this.gameObject);
	}
	private void addForce()
	{
		this.gameObject.GetComponent<Rigidbody> ().AddForce (forceVector * force, ForceMode.Impulse);
	}
}
