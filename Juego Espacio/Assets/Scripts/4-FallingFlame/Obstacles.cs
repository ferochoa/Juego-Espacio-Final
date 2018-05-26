using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	public float speed;

	void Start () {
		Invoke ("destroy", 4);
	}


	void Update () {
		transform.Translate (-Vector3.up * Time.deltaTime * speed);
	}

	void destroy()
	{
		Destroy (this.gameObject);
	}
}
