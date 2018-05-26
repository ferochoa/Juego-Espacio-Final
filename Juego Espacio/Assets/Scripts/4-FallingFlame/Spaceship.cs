using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {

	public LeftJoystick leftJoystick;
	private Vector3 leftJoystickInput;
	private float speed;
	private float xDirection;

	void FixedUpdate()
	{
		leftJoystickInput = leftJoystick.GetInputDirection();
		speed = 15f;
	}
	void Update()
	{
		setXdirection ();
		move ();
	}
	private void move()
	{
		this.transform.Translate (new Vector3(xDirection *Time.deltaTime * speed , 0));
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
}
