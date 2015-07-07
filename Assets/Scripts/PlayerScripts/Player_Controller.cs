using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary {
	
	public float xMin, xMax, yMin, yMax;
}

public class Player_Controller : MonoBehaviour {
	
	public float moveSpeed;
	public Boundary boundary;
	public float currSpeedX;
	public float currSpeedY;


	void Start () {
		moveSpeed = 5f;
	}

	void FixedUpdate () {
		
		currSpeedX = Mathf.Lerp(0, Input.GetAxis("Horizontal") * moveSpeed, 0.5f);
		currSpeedY = Mathf.Lerp(0, Input.GetAxis("Vertical") * moveSpeed, 0.5f);
		rigidbody2D.velocity = new Vector2(currSpeedX, currSpeedY);


		rigidbody2D.position = new Vector3 
			(
				Mathf.Clamp (rigidbody2D.position.x, boundary.xMin, boundary.xMax), 
				Mathf.Clamp (rigidbody2D.position.y, boundary.yMin, boundary.yMax),
				0.0f
			);


		//float moveV = Input.GetAxis ("Vertical");
		//float moveH = Input.GetAxis ("Horizontal");
		//rigidbody2D.AddForce (gameObject.transform.up * moveSpeed * moveV);
		//rigidbody2D.AddForce (gameObject.transform.right * moveSpeed * moveH);

		//if(Input.GetAxis("Vertical") > 0)
		//{
		//	transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
		//	//Debug.Log ("UP");
		//}
		//if(Input.GetAxis("Horizontal") > 0)
		//{
		//	transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
		//	//Debug.Log ("RIGHT");
		//}
		//if(Input.GetAxis("Vertical") < 0)
		//{
		//	transform.Translate(Vector2.up * -moveSpeed * Time.deltaTime);
		//	//Debug.Log ("DOWN");
		//}
		//if(Input.GetAxis("Horizontal") < 0)
		//{
		//	transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
		//	//Debug.Log ("LEFT");
		//}



	}
}