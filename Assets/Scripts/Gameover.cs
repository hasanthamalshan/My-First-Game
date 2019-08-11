using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gameover : MonoBehaviour {
    public Text S;
	public Text high;

	// Use this for initialization
	void Start () {
		S.text = "Score : "+ GameManager.score.ToString();
	
		 if(GameManager.score >= PlayerPrefs.GetInt("HighScore")){
				high.text = "New High Score Set as : " + PlayerPrefs.GetInt("HighScore").ToString();
				}
	}

	public void gameover(){
		GameManager.restartGame();
		//Debug.Log("end");
	}
	public void quit(){
		GameManager.quitGame();
		//Debug.Log("end");
	}
}
