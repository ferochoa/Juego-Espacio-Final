using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsNave : MonoBehaviour {

	public void RightDown()
    {
        GetComponent<Animator>().SetBool("Right", true);
    }
    public void LeftDown()
    {
        GetComponent<Animator>().SetBool("Left", true);
    }
    public void RightUp()
    {
        GetComponent<Animator>().SetBool("Right", false);
    }
    public void LeftUp()
    {
        GetComponent<Animator>().SetBool("Left", false);
    }

}
