using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	private float speed = 50;
	private float direction;

	void Update () {
		this.gameObject.transform.Rotate (0,0, -direction * speed * Time.deltaTime);
	}
	public void setDirection(float direction)
	{
		this.direction = direction;
	}
}
