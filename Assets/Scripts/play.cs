using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class play : MonoBehaviour {
    public Text HS;
	int highestscore;

	void Start() {
		highestscore = PlayerPrefs.GetInt("HighScore");
		HS.text = "Highest Score : " + highestscore.ToString();
	}
	public void Play(){
		GameManager.flag = 1;
		SceneManager.LoadScene(0);
	}
}
