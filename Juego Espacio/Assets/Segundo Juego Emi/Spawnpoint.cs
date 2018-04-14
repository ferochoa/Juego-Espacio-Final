using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

	[SerializeField]
	private float XLimitRight, XLimitLeft,YLimitUp, YLimitDown,YPosition, speed,dropTime,XDirection, YDirection;
	private float XInitialPosition;
	private Vector2 movement;
	public GameObject asteroid;
	private float levelTime;
	private bool timeIsRunning;

	void Start()
	{		
		XInitialPosition = Random.Range (XLimitLeft +1, XLimitRight);
		timeIsRunning = true;
		StartCoroutine (timer ());
	}
	void Update()
	{
		motion ();
	}
	private void motion()
	{
		movement = new Vector2 (XDirection, YDirection);
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = movement * speed;

		if (this.gameObject.transform.position.x > XLimitRight)
			XDirection = -1;		
		if (this.gameObject.transform.position.x < XLimitLeft) 
			XDirection = 1;	
		if (this.gameObject.transform.position.y > YLimitUp)
			YDirection = -1;		
		if (this.gameObject.transform.position.y < YLimitDown) 
			YDirection = 1;	
	}	
	IEnumerator timer()
	{
		while (timeIsRunning == true) {
			yield return new WaitForSeconds (1);
			levelTime++;
			if (levelTime % dropTime == 0)
				Instantiate (asteroid, this.gameObject.transform.position, this.gameObject.transform.rotation);
		}
	}
}
