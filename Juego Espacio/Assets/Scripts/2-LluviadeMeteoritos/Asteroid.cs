using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	[SerializeField]
	private float lifeTime, force;
	private Vector2 forceVector;

	void Start()
	{
		Invoke ("destroy", lifeTime);
		if (this.gameObject.tag == "right spawn")
			forceVector = new Vector2 (3,-3);
		if (this.gameObject.tag == "left spawn")
			forceVector = new Vector2 (-3, -3);
		else
			forceVector = new Vector2 (0, -3);
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
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "bullet") {
			destroy ();
			Destroy (col.gameObject);
		}
	}
}
