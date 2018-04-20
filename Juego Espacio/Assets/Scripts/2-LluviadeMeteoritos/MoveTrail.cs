using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrail : MonoBehaviour {

	private float speed;

	void Start () {
		speed = 100;
		Invoke ("destroy", 3);
	}	

	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * speed);
	}
	void destroy()
	{
		Destroy (this.gameObject);
	}
}
