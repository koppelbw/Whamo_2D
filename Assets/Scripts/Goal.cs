using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	public Rigidbody2D ballPrefab;
	public Transform field;
	public GameController gameController;

	// GOAL
	void OnTriggerEnter2D(Collider2D collidedWith) {
		
		if (collidedWith.gameObject.tag == "Ball") {
			// destroy ball
			Destroy(collidedWith.gameObject);
			// spawn ball in middle of field
			Instantiate(ballPrefab, field.position, field.rotation);

			// update score
			gameController.AddScore(1);



		}
	}
}