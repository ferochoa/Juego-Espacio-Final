using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionInOrbit : MonoBehaviour {

	private GameObject spaceShip;
	private PlayerController2 pc2;

	void Start () {
		spaceShip = GameObject.Find ("Spaceship");
		pc2 =spaceShip. GetComponent<PlayerController2> ();
	}	

	void Update () {
		pc2.setSpaceshipPosition (this.transform.position);
	}

}
