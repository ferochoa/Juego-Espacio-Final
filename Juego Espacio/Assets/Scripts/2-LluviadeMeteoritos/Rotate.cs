using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	private float speed = 80;
	private float direction;
	public LeftJoystick leftJoystick;
	private Vector3 leftJoystickInput;

	void Update () {
		this.gameObject.transform.Rotate (0,0, -leftJoystickInput.x * speed * Time.deltaTime);
	}
	/*public void setDirection(float direction)
	{
		this.direction = direction;
	}*/
	void FixedUpdate()
	{
		leftJoystickInput = leftJoystick.GetInputDirection();
	}
}
