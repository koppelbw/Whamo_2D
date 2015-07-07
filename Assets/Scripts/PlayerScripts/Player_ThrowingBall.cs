using UnityEngine;
using System.Collections;

public class Player_ThrowingBall : MonoBehaviour {

	private Ball_Controller ballController;
	private Player_HoldingBall playerHoldingBall;
	private Player_Controller playerController;
	public Rigidbody2D ballPrefab;
	public float throwPower;
	public Transform playerTransform;
	public Transform shotSpawn;

	// Use this for initialization
	void Start () {
		ballController = GameObject.FindGameObjectWithTag ("BallController").GetComponent<Ball_Controller> ();
		playerHoldingBall = this.gameObject.GetComponent<Player_HoldingBall> ();
		playerController = this.gameObject.GetComponent<Player_Controller> ();
		throwPower = 0.25f;
		playerTransform = this.transform;
	}


	void Update() {

		// Release the ball
		if (Input.GetButtonUp ("Fire1") && playerHoldingBall.IsHoldingBall == true) {
			Debug.Log ("Throwing ball");
			playerController.moveSpeed = 5f;
			
			//Instantiate Ball Prefab
			Rigidbody2D ballInstance = Instantiate(ballPrefab, shotSpawn.position, shotSpawn.rotation) as Rigidbody2D;
			ballInstance.velocity = new Vector2(0.0f, 10 * throwPower);
			
			//ballController.isLooseBall = true;
			//ballController.isHeldBy = null;
			ballController.isBeingThrown = true;
			playerHoldingBall.IsHoldingBall = false;
			throwPower = 0.25f;
		}
	}

	void FixedUpdate () {
	
		// Increase power of throw
		if (Input.GetButton ("Fire1") && playerHoldingBall.IsHoldingBall == true) {
			playerController.moveSpeed = 0;
			if(throwPower < 1.0f)
				throwPower += 0.01f;
		}
	}
}