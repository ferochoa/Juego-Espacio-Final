using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject asteroids;
	public float spawnTime;
	private float xLeftLimit;
	private float xRightLimit;
	private float ySpawnPosition;
	private Vector3 xSpawnPosition;
	private float time;
	private bool shipDestroyed;

	void Start () {

		xLeftLimit = -12f;
		xRightLimit = 20f;
		ySpawnPosition = 25f;
		spawnTime = 3f;

		StartCoroutine (timer());
	}
	void Update()
	{

	}
	private void setSpawnPosition()
	{
		float position = Random.Range (xLeftLimit,xRightLimit);
		xSpawnPosition = new Vector3 (position,ySpawnPosition,0);
	}
	private void instantiateAsteroids()
	{
		Instantiate (asteroids,xSpawnPosition, asteroids.transform.rotation);
	}

	IEnumerator timer()
	{
		while(shipDestroyed == false)
		{
			yield return new WaitForSeconds (1f);
			time++;
			if (time % spawnTime == 0) {
				setSpawnPosition ();
				instantiateAsteroids ();
			}
		}
	}
}
