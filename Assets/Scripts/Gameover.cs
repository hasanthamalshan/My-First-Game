using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gameover : MonoBehaviour {
    public Text S;
	// Use this for initialization
	void Start () {
		S.text = "Score : "+ GameManager.score.ToString();
	}

	public void gameover(){
		GameManager.restartGame();
		//Debug.Log("end");
	}
	  
}
