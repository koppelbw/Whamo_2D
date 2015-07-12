using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreTextTeam1;
	public GUIText scoreTextTeam2;
	public int team1_Score;
	public int team2_Score;
	public bool isGameOver;
	public string winningTeam;


	void Start () {
		team1_Score = 0;
		team2_Score = 0;
		isGameOver = false;
		winningTeam = "";

		UpdateScore ();
	}


	void Update () {
	
	}

	public void AddScoreTeam1 (int points) {
		team1_Score += points;
		UpdateScore ();
	}

	public void AddScoreTeam2 (int points) {
		team2_Score += points;
		UpdateScore ();
	}

	void UpdateScore() {
		scoreTextTeam1.text = "Team1: " + team1_Score;
		scoreTextTeam2.text = "Team2: " + team2_Score;
	}

	void checkGameOver() {
		if (team1_Score >= 10) {
			isGameOver = true;
			winningTeam = "Team 1";
		}

		
		if (team2_Score >= 10) {
			isGameOver = true;
			winningTeam = "Team 2";
		}
	}

	// Duplicate Start()
	void resetGame() {
		team1_Score = 0;
		team2_Score = 0;
		isGameOver = false;
		winningTeam = "";
		
		UpdateScore ();
	}
}
