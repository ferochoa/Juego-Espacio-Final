using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	void Update()
	{
		this.gameObject.transform.Rotate (0,0,-Input.GetAxis("Horizontal") * 50f* Time.deltaTime);
	}
}
