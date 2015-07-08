using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundaries {
	
	public float xMin, xMax, yMin, yMax;


}

public class Boundary : MonoBehaviour {

	public Boundaries boundaries;

	void Start() {
		boundaries.xMin = -2.8f;
		boundaries.xMax = 2.8f;
		boundaries.yMin = -3.8f;
		boundaries.yMax = 4.0f;
	}

	void FixedUpdate () {

		rigidbody2D.position = new Vector3 
			(
				Mathf.Clamp (rigidbody2D.position.x, boundaries.xMin, boundaries.xMax), 
				Mathf.Clamp (rigidbody2D.position.y, boundaries.yMin, boundaries.yMax),
				0.0f
			);
	}
}
