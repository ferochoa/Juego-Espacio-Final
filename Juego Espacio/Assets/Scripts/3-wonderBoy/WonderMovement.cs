using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonderMovement : MonoBehaviour {

    public float speed;

    public float jumpSpeed;

    public Transform florComprobation;
    public LayerMask whatIsFlor;

    private Vector3 movement;

    [HideInInspector]
    public bool jump, touchFlor;

	void Start ()
    {
       
	}

	void Update ()
    {
        MoveWonder();

        InternalJump();
    }

    void MoveWonder()
    {      
        transform.Translate(movement);

        if (jump && touchFlor)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,jumpSpeed));

            jump = false;
        }
        else
        {
            movement = new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void InternalJump()
    {
        if (Physics2D.OverlapCircle(florComprobation.position, 0.2f, whatIsFlor))
        {
            touchFlor = true;
        }
        else
        {
            touchFlor = false;
        }
    }

    public void JumpWonder()
    {
        if(touchFlor)
        {
            jump = true;
        }
    }
}
