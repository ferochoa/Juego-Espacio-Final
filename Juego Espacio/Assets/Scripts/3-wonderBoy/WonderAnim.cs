using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonderAnim : MonoBehaviour {

    private Animator animator;

    private wonderLife life;

    private WonderMovement movement;

	void Start ()
    {
        animator = GetComponent<Animator>();
        life = GetComponent<wonderLife>();
        movement = GetComponent<WonderMovement>();
	}
	
	
	void Update ()
    {
		if(life.life < 1)
        {
            animator.SetBool("Damage", false);
            animator.SetBool("Death", true);
        }
        if(movement.jump || !movement.touchFlor)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "LessLife")
        {
            animator.SetBool("Damage", true);
        }
        else
        {
            if(collision.tag == "Death")
            {
                animator.SetBool("Damage", false);
                animator.SetBool("Death", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "LessLife")
        {
            animator.SetBool("Damage", false);
        }
    }
}
