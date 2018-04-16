using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour {	
	
	private float speed;

	void Start()
	{
		speed = 10f;
	}
	void FixedUpdate () {
		this.gameObject.transform.Rotate (0,-1 * speed * Time.deltaTime,0);
	}
}
