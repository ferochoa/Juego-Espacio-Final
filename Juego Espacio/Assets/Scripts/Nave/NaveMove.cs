using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour 
{
    public float speed;
    private Vector3 direction;
		
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

        if(direction.y > 0 && transform.position.y > direction.y)
        {
            float temp_y = direction.y;
            direction = Vector3.zero;
            StartCoroutine(GoMiddle(temp_y));
        }
        else
        {

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

    IEnumerator GoMiddle(float Height)
    {
        yield return new WaitForSeconds(3f);

        direction = new Vector3(0, (Height * -1),0);
    }
}
