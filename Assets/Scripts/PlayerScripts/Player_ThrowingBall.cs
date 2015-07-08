using UnityEngine;
using System.Collections;

public class Player_ThrowingBall : MonoBehaviour {

	private Ball_Controller ballController;
	private Player_HoldingBall playerHoldingBall;
	private Player_Movement playerController;
	public Rigidbody2D ballPrefab;
	public Transform playerTransform;
	public Transform shotSpawn;
	public float throwSpeed;
	public float throwPower;
	
	void Start () {
		ballController = GameObject.FindGameObjectWithTag ("BallController").GetComponent<Ball_Controller> ();
		playerHoldingBall = this.gameObject.GetComponent<Player_HoldingBall> ();
		playerController = this.gameObject.GetComponent<Player_Movement> ();
		throwSpeed = 10.0f;
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
			ballInstance.velocity = new Vector2(shotSpawn.up.x * throwSpeed * throwPower, shotSpawn.up.y * throwSpeed * throwPower);
			Debug.Log("Throw Direction: " + shotSpawn.up);


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
			playerController.moveSpeed = 0.5f;
			if(throwPower < 1.0f)
				throwPower += 0.01f;
		}
	}
}