using UnityEngine;
using System.Collections;

public class Shot_Aim : MonoBehaviour {


	void FixedUpdate() {

		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);

		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		//rigidbody2D.angularVelocity = 0;
	}
}
