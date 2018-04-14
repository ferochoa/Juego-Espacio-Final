using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour 
{
    public float speed;
    Vector3 direction;
		
	void Start () 
	{
        direction = Vector3.zero;
	}
	
		
	void Update () 
	{
        Move();
    }
    
    void Move()
    {
        transform.Translate(direction.x * Time.deltaTime * speed, direction.y * Time.deltaTime, speed * Time.deltaTime);

        if(direction.y > 0)
        {
            if(transform.position.y > direction.y)
            {
                direction = Vector3.zero;
            }
        }
    }

    public void SetDirection(float dir)
    {
        direction = new Vector3(dir, 0, 0);
    }

    public void SetHeight(float Yaxis)
    {
        direction = new Vector3(0, Yaxis, 0);
    }


}
