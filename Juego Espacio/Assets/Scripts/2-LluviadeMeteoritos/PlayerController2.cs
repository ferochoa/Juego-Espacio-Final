using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour,IPlayer {

	public GameObject positionInOrbitGO;
	private Vector3 positionInOrbit;
	private GameObject shotSpawn;
	private GameObject shotSpawn_1;
	public GameObject bullet;
	public GameObject target;

	void Start()
	{
		shotSpawn = GameObject.Find ("shotSpawn");
		shotSpawn_1 = GameObject.Find ("shotSpawn_1");		
	}


	void Update()
	{		
		updatePlayerPosition();
		if(Input.GetKeyDown(KeyCode.Space))
		shoot ();
	}
	private void updatePlayerPosition()
	{
		this.transform.position = new Vector3 (positionInOrbit.x, positionInOrbit.y, positionInOrbit.z);
	}
	public void setSpaceshipPosition(Vector3 position)
	{		
		positionInOrbit = position;
	}
	public void move()
	{

	}
	public void shoot()
	{
		/*Instantiate (bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
		Instantiate (bullet, shotSpawn_1.transform.position, shotSpawn_1.transform.rotation);*/
		Vector3 targetPosition = new Vector3 (target.transform.position.x,target.transform.position.y, target.transform.position.z);
		Vector3 spawnPosition = new Vector3 (shotSpawn.transform.position.x,shotSpawn.transform.position.y,shotSpawn.transform.position.z);

		RaycastHit hit;
		Physics.Raycast (spawnPosition,targetPosition - spawnPosition, out hit);
		Debug.DrawLine (spawnPosition,targetPosition);
	}
}
