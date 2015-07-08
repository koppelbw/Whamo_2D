using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
	
	public float moveSpeed;
	public float currSpeedX;
	public float currSpeedY;


	void Start () {
		moveSpeed = 5f;
	}

	void FixedUpdate () {
		
		currSpeedX = Mathf.Lerp(0, Input.GetAxis("Horizontal") * moveSpeed, 0.5f);
		currSpeedY = Mathf.Lerp(0, Input.GetAxis("Vertical") * moveSpeed, 0.5f);
		rigidbody2D.velocity = new Vector2(currSpeedX, currSpeedY);

	}
}