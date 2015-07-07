using UnityEngine;
using System.Collections;

public class Player_HoldingBall : MonoBehaviour {

	private Ball_Controller ballController;
	public bool isHoldingBall;

	// Use this for initialization
	void Start () {
		ballController = GameObject.FindGameObjectWithTag ("BallController").GetComponent<Ball_Controller> ();
		isHoldingBall = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collidedWith) {
		//Debug.Log ("Trigger Entered!");
		
		if (collidedWith.gameObject.tag == "Ball") {
			isHoldingBall = true;
			Debug.Log (gameObject.name + " picked up the ball!");

			Destroy(collidedWith.gameObject);
			Debug.Log ("DESTROYED the ball object");

			ballController.isHeldBy = this.gameObject;
			ballController.isBeingThrown = false;
			ballController.isLooseBall = false;
			
			//gameObject.transform.parent = GameObject.FindGameObjectWithTag("PlayerHoldingBall").transform;
			
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
