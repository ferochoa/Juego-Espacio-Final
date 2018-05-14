using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

	public GameObject player;
	private PlayerController2 pc2;
	void Start () {
	pc2 = player.GetComponent<PlayerController2> ();
	}
	
	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("choco a la tierra");
		pc2.lives--;
	}
}
