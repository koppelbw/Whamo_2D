using UnityEngine;
using System.Collections;

public class Player_HoldingBall : MonoBehaviour {

	private Ball_Controller ballController;
	public bool isHoldingBall;

	void Start () {
		ballController = GameObject.FindGameObjectWithTag ("BallController").GetComponent<Ball_Controller> ();
		isHoldingBall = false;
	}

	// Pick Ball Up
	void OnTriggerEnter2D(Collider2D collidedWith) {
		
		if (collidedWith.gameObject.tag == "Ball" && !ballController.isBeingThrown) {
			isHoldingBall = true;
			Debug.Log (gameObject.name + " picked up the ball!");

			Destroy(collidedWith.gameObject);
			Debug.Log ("DESTROYED the ball object");

			ballController.isHeldBy = this.gameObject;
			ballController.isBeingThrown = false;
			ballController.isLooseBall = false;
		}
		else {
			// TODO: TEMPORARY IMPLEMENTATION OF RESETING THE BALL
			ballController.isBeingThrown = false;
			ballController.isLooseBall = true;
			ballController.isHeldBy = null;
		}
	}

	public bool IsHoldingBall {
		get {
			return isHoldingBall;
		}
		set {
			isHoldingBall = value;
		}
	}
}