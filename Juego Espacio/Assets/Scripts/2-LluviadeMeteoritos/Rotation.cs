using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	private float direction;

	void Start () {
		
	}
	

	void Update () {
		this.gameObject.transform.Rotate (0,0,-direction * 50f* Time.deltaTime);
	}
	public void setDirection(float direction)
	{
		this.direction = direction;
	}
}
