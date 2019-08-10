﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
	public Ball ball;
	public Paddle paddle;
	public static int level = 1;
	public static int hit;
	public static Vector2 bottomLeft;
	public static Vector2 topRight;

	public static int score = 0;

	// Use this for initialization
	void Start () {
		bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
		topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
		Instantiate(ball);

		Paddle paddle1  = Instantiate(paddle) as Paddle;
		Paddle paddle2  = Instantiate(paddle) as Paddle;

		paddle1.Init(true);
		paddle2.Init(false);
	}

    public static void end(){
		SceneManager.LoadScene(1);
		
	}

	public static void restartGame(){
		SceneManager.LoadScene(0);
		score = 0;
	}

	public static void nextLevel(){

	}
	
	
}
