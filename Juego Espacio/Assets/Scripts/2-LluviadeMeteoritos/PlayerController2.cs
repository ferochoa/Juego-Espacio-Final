using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour,IPlayer {

	public GameObject positionInOrbitGO;
	private Vector3 positionInOrbit;
	private GameObject shotSpawn;
	private GameObject shotSpawn_1;
	public GameObject bullet;
	public GameObject target;
	public GameObject target_1;
	public GameObject bulletTrail;
	private int lives;

	void Start()
	{
		shotSpawn = GameObject.Find ("shotSpawn");
		shotSpawn_1 = GameObject.Find ("shotSpawn_1");	
		lives = 5;
	}
	void FixedUpdate()
	{		
		updatePlayerPosition();
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
		//no se utiliza en este caso
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag != "bullet")
		{
			lives--;
			if (lives <= 0)
				restartLevel();
		}
	}
	public void restartLevel()
	{
		SceneManager.LoadScene ("2-LluviadeMeteoritos");
	}
	public void shoot()
	{		
		Vector3 targetPosition = new Vector3 (target.transform.position.x,target.transform.position.y, target.transform.position.z);
		Vector3 spawnPosition = new Vector3 (shotSpawn.transform.position.x,shotSpawn.transform.position.y,shotSpawn.transform.position.z);

		Vector3 targetPosition1 = new Vector3 (target_1.transform.position.x,target_1.transform.position.y, target_1.transform.position.z);
		Vector3 spawnPosition1 = new Vector3 (shotSpawn_1.transform.position.x,shotSpawn_1.transform.position.y,shotSpawn_1.transform.position.z);

		RaycastHit hit,hit2;
		Physics.Raycast (spawnPosition,targetPosition - spawnPosition, out hit);
		Physics.Raycast (spawnPosition1,targetPosition1 - spawnPosition1, out hit2);
		effect ();
		Debug.DrawLine (spawnPosition,targetPosition);
		Debug.DrawLine (spawnPosition1,targetPosition1);
	}
	private void effect()
	{
		Instantiate (bulletTrail, shotSpawn.transform.position, shotSpawn.transform.rotation);
		Instantiate (bulletTrail, shotSpawn_1.transform.position, shotSpawn_1.transform.rotation);
	}
}
