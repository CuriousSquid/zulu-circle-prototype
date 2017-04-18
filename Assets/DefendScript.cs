using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefendScript : MonoBehaviour {

	[SerializeField] int health;

	void Start () {
		
	}

	void FixedUpdate () {
		if (0 == health) {
			this.GetComponent<SpriteRenderer> ().color = Color.red;
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.gameObject.tag == "enemy") {
			Destroy (collision.collider.gameObject);
			--health;
		}
	}
}
