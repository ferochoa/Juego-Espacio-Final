using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{
    public string scenename;
		
	void Start () 
	{


	}
	
		
	void Update () 
	{


	}

    public void loadscene()
    {
        SceneManager.LoadScene(scenename);
    }

}
