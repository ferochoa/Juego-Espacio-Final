using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {


    [SerializeField] private float speed;
	private float direction;
	private float shotRate;
	private float nextShot;
    [SerializeField] private float lives;
    public float high;
    private float middleHigh;

    private Vector3 movement;

    private GameObject shotSpawn;
	private GameObject shotSpawn_1;
	public GameObject bullet;
   
    public bool m_up, m_down,ver;

    private int dir;

    public string Scenename;


	void Start()
	{		
		shotRate = .2f;
		nextShot = 0f;
		speed = 30f;
		shotSpawn = GameObject.Find ("shotSpawn");
		shotSpawn_1 = GameObject.Find ("shotSpawn_1");
        movement = new Vector3(direction, 0.0f, 1f);
		lives = 5;
        m_up = false;
        m_down = false;
        ver = true;
        middleHigh = transform.position.y;
	}
	void FixedUpdate()
	{
		move ();
	}
	void OnCollisionEnter(Collision col)
	{
        if(col.gameObject.tag != "bullet")
        {
            lives--;
            if (lives <= 0)
                restartLevel();
        }
		
	}
	private void move()
	{		
		this.gameObject.GetComponent<Rigidbody> ().velocity = movement * speed;
        Y_move();
	}

    private void Y_move()
    {
        if(m_up == true)//si es true es por que presione el boton
        {
            if(this.transform.position.y <= high + middleHigh)//si la posicion de la nave es menor a la altura maxima en el eje Y 
            {
                movement = new Vector3(direction, 1, 1f);//lo muevo hacia esa posicion
                dir = -1;
            }
            else
            {
                if(ver == true)
                {
                    ver = false;
                    StartCoroutine(movingUp());
                }
            }
        }
        else
        {
            if(m_down == true)
            {
                if (this.transform.position.y >= -high + middleHigh)
                {
                    movement = new Vector3(direction, -1, 1f);
                    dir = 1;
                }
                else
                {
                    if (ver == true)
                    {
                        ver = false;
                        StartCoroutine(movingDown());
                    }
                }
            }
            else
            {
                if(dir == 1)
                {
                    if(this.transform.position.y < middleHigh)
                    {
                        movement = new Vector3(direction, dir * 1, 1f);
                    }
                    else
                    {
                        movement = new Vector3(direction, 0f, 1f);
                    }
                }
                else
                {
                    if (this.transform.position.y > middleHigh)
                    {
                        movement = new Vector3(direction, dir *1, 1f);
                    }
                    else
                    {
                        movement = new Vector3(direction, 0f, 1f);
                    }
                }
            }
        }
    }

	public void setDirection(float direction)
	{
		this.direction = direction;
        movement = new Vector3(direction, 0.0f, 1f);
    }
	public void shoot()
	{
		if (Time.time > nextShot) {
			nextShot = Time.time + shotRate;
			Instantiate (bullet, shotSpawn.transform.position, shotSpawn.transform.rotation);
			Instantiate (bullet, shotSpawn_1.transform.position, shotSpawn_1.transform.rotation);
		}
	}
	public void moveUp()
	{	
		//StartCoroutine (movingUp());
        if(m_down == false)
        {
            m_up = true;
        }
	}
	public void moveDown()
	{
        //StartCoroutine (movingDown());
        if (m_up == false)
        {
            m_down = true;
        }
    }
	public void restartLevel()
	{
		SceneManager.LoadScene (Scenename);
	}
    


	#region coroutines
	IEnumerator movingUp()
	{
        yield return new WaitForSeconds(3f);
        m_up = false;
        ver = true;

        /*movement = new Vector3 (direction, 5f, 0f);
		yield return new WaitForSeconds (3f);
		movement = new Vector3 (direction, -5f, 0f);
		yield return new WaitForSeconds (.6f);
		movement = new Vector3 (direction, 0.0f, 1f);
		//Vector3 temp = new Vector3 (direction, 415f, 0.0f);
		//this.gameObject.transform.position = temp;
        */
    }
	IEnumerator movingDown()
	{

        yield return new WaitForSeconds(3f);
        m_down = false;
        ver = true;
        /*
		movement = new Vector3 (direction, -5f, -0);
		yield return new WaitForSeconds (.5f);
		movement = new Vector3 (direction, 5f, 0f);
		yield return new WaitForSeconds (.5f);
		movement = new Vector3 (direction, 0.0f, 1f);
		//Vector3 temp = new Vector3 (direction, 415f, 0.0f);
		//this.gameObject.transform.position = temp;
        */
    }


	#endregion
}
