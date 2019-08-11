using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	Vector2 direction;
	public static float speed = 5;
	float radius;
	// Use this for initialization
	void Start () {
		direction = Vector2.one.normalized;
		radius = transform.localScale.x /2;

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(direction*speed*Time.deltaTime);

		if((transform.position.y < GameManager.bottomLeft.y + radius) && (direction.y < 0)){
			direction.y = -direction.y;
		}
		if((transform.position.y > GameManager.topRight.y - radius) && (direction.y > 0)){
			direction.y = -direction.y;
		}
		if((transform.position.x < (GameManager.bottomLeft.x + radius + 1.3f)) && (direction.x < 0)){
			if(GameManager.score > PlayerPrefs.GetInt("HighScore")){
				PlayerPrefs.SetInt("HighScore",GameManager.score);
					
			}
			GameManager.end();
		}
		if((transform.position.x > (GameManager.topRight.x - radius - 1.3f)) && (direction.x > 0)){
			if(GameManager.score > PlayerPrefs.GetInt("HighScore")){
				PlayerPrefs.SetInt("HighScore",GameManager.score);
			}
			GameManager.end();
		}
	}

    void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Paddle"){
			//bool isRight = other.GetComponent<Paddle>().isRight;
			GameManager.score++;
			GameManager.hit++;
			
             direction.x = -direction.x;

			if(GameManager.hit%5 == 0){
				speed ++;
				GameManager.level++;
			}
		    // if((isRight == true) && (direction.x < 0) ){
			//  	direction.x = -direction.x;
			//  }
			// else if((isRight == false) && (direction.x > 0) ){
			//  	direction.x = -direction.x;
			//  }
			//Debug.Log(GameManager.score);
		}
	}
}
