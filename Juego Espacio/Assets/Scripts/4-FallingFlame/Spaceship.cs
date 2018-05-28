using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {

	public LeftJoystick leftJoystick;
	private Vector3 leftJoystickInput;
	private float speed;
	private float xDirection;
	private float xMaxPosition;
	private float xMinPosition;
	private float yPosition;
	private int lives;

	void FixedUpdate()
	{
		leftJoystickInput = leftJoystick.GetInputDirection();
		speed = 25f;
	}
	void Start()
	{
		xMaxPosition = 20f;
		xMinPosition = -20f;
		yPosition = -0.7f;
		lives = 5;
	}
	void Update()
	{
		setXdirection ();
		move ();
	}
	private void move()
	{
		this.transform.Translate (new Vector3(xDirection *Time.deltaTime * speed , 0));
		if (this.gameObject.transform.position.x > xMaxPosition)
			this.gameObject.transform.position = new Vector3 (xMaxPosition, yPosition, 0);
		if (this.gameObject.transform.position.x < xMinPosition)
			this.gameObject.transform.position = new Vector3 (xMinPosition,yPosition,0);
	}
	private void setXdirection()
	{
		if (leftJoystickInput.x > 0.9f)
			xDirection = 1;
		if (leftJoystickInput.x < -0.9f)
			xDirection = -1;
		if (leftJoystickInput.x == 0)
			xDirection = 0;		
	}
	void OnTriggerEnter(Collider col)
	{ 		
			lives--;
			Debug.Log (lives);
	}
}
