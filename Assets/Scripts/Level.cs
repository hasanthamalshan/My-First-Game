using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level : MonoBehaviour {
    public Text level;
	public Text score;
	public Text HS;
	// Use this for initialization
	void Start () {
		level.text = "Level : 1";

	}
	
	// Update is called once per frame
	void Update () {
		level.text = "Level : " + GameManager.level.ToString();
		score.text = "Score : "+ GameManager.score.ToString();
		HS.text = "HS :" + PlayerPrefs.GetInt("HighScore").ToString();

	}
}
