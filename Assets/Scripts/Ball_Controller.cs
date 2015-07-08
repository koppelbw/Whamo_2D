using UnityEngine;
using System.Collections;

public class Ball_Controller : MonoBehaviour {

	public bool isLooseBall;
	public GameObject isHeldBy;
	public bool isBeingThrown;

	void Start () {
		isLooseBall = true;
		isHeldBy = null;
		isBeingThrown = false;
	}

	bool IsLooseBall {
		get {
			return this.isLooseBall;
		}
		set {
			isLooseBall = value;
		}
	}

	GameObject IsHeldBy {
		get {
			return this.isHeldBy;
		}
		set {
			isHeldBy = value;
		}
	}

	bool IsBeingThrown {
		get {
			return this.isBeingThrown;
		}
		set {
			isBeingThrown = value;
		}
	}
}