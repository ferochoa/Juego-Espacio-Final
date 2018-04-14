using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMove : MonoBehaviour 
{
    public float speed;
    private float shotRate;
    private float nextShot;

    private Vector3 direction;

    private bool y_pos , y_neg;

    private GameObject shotSpawn;
    private GameObject shotSpawn_1;
    public GameObject bullet;

    void Start () 
	{
        direction = Vector3.zero;
        shotSpawn = GameObject.Find("shotSpawn");
        shotSpawn_1 = GameObject.Find("shotSpawn_1");
        shotRate = .2f;
        nextShot = 0f;
    }
	
	void Update () 
	{
        Move();
    }
    
    void Move()
    {
        //Movimiento continuo de la nave
        transform.Translate(direction.x * Time.deltaTime * speed, direction.y * Time.deltaTime, speed * Time.deltaTime);

        //Si voy para arriba
        if (y_pos)
        {
            if (direction.y > 0 && transform.position.y > direction.y)
            {
                float temp_y = direction.y;
                direction = Vector3.zero;
                StartCoroutine(GoMiddle(temp_y));
            }
            else
            {
                if (transform.position.y < 0)
                {
                    direction = Vector3.zero;
                    y_pos = false;
                }
            }
        }

        //Si voy para abajo
        else
        {
            if (y_neg)
            {
                if (direction.y < 0 && transform.position.y < direction.y)
                {
                    float temp_y = direction.y;
                    direction = Vector3.zero;
                    StartCoroutine(GoMiddle(temp_y));
                }
                else
                {
                    if (transform.position.y > 0)
                    {
                        direction = Vector3.zero;
                        y_neg = false;
                    }
                }
            }
        }
    }

    public void shoot()
    {
        if (Time.time > nextShot)
        {
            nextShot = Time.time + shotRate;
            Instantiate(bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
            Instantiate(bullet, shotSpawn_1.transform.position, shotSpawn_1.transform.rotation);
        }
    }

    public void SetDirection(float dir)
    {
        direction = new Vector3(dir, 0, 0);
    }

    public void SetHeight(float Yaxis)
    {
        if (!y_pos && !y_neg)
        {
            if (Yaxis > 0) { y_pos = true; }
            else { y_neg = true; }

            direction = new Vector3(0, Yaxis, 0);
        }
    }

    IEnumerator GoMiddle(float Height)
    {
        yield return new WaitForSeconds(2f);

        direction = new Vector3(0, (Height * -1),0);
    }
}
