using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	[SerializeField] GameObject target;
	[SerializeField] float		speed;

	void Start () {
		GetComponent<SpriteRenderer> ().color = Random.ColorHSV (0, 1, 1, 1, 1, 1, 1, 1);;
	}

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, speed * Time.deltaTime);
	}
}
