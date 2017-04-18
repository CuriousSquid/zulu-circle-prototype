using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour {

	[SerializeField] GameObject parent;
	[SerializeField] float 		speed;

	enum Direction {
		COUNTERCLOCKWISE=1,
		CLOCKWISE=-1,
		NONE=0
	}

	void Start () {
		
	}

	void FixedUpdate () {
		transform.RotateAround (parent.transform.position, Vector3.forward, speed * (int)getDirection ());
	}

	Direction getDirection() {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			return Direction.COUNTERCLOCKWISE;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			return Direction.CLOCKWISE;
		}
		return Direction.NONE;
	}



	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.gameObject.tag == "enemy") {
			Destroy (collision.collider.gameObject);
		}
	}
}
