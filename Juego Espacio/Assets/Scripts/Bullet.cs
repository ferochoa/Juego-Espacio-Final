using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField]
	private float speed;
	private Vector3 movement;

	public GameObject Explison;

	void Start () {
		speed = 100f;
		movement = new Vector3 (0.0f,0.0f,1f);
		move ();
		Invoke ("destroy",3f);
	}

	private void move()
	{
		this.gameObject.GetComponent<Rigidbody> ().velocity = movement * speed;
	}
	private void destroy()
	{
		Destroy (this.gameObject);
	}
	void OnCollisionEnter(Collision col)
	{		
		if (col.gameObject.tag == "red Obstacle") {
			Destroy (col.gameObject);

		}

		Explison.SetActive (true);
		destroy ();
	}
}
