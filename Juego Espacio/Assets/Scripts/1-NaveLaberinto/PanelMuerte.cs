using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelMuerte : MonoBehaviour {

    public NaveDeath naveDeath;

    public Text Score;
	
	void Start ()
    {
        int score = (int)naveDeath.distanceToWin;

        Score.text = score.ToString();
	}
	
    public void TryAgain()
    {
        SceneManager.LoadScene("1-NaveLaberinto");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("0-Menu");
    }
}
