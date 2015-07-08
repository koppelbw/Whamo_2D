using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	public int score;


	void Start () {
		score = 0;
		UpdateScore ();
	}


	void Update () {
	
	}

	public void AddScore (int points) {
		score += points;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreText.text = "SCORE: " + score;
	}
}
