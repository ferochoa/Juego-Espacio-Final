using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Puntaje : MonoBehaviour {

    public Text Puntos_Str;
    static public int Puntos_Int;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {

        Puntos_Str.text = Puntos_Int.ToString();


	}
}
