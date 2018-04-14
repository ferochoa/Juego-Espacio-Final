using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour 
{
    public Transform nave;
    public float Y;
		
	void Update () 
	{
        transform.position = new Vector3(nave.transform.position.x, Y, nave.transform.position.z);
	}

}
