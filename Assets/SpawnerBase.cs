using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour {

	[SerializeField] GameObject prototype;

	protected Object Spawn() {
		return Instantiate (prototype, transform.position, Quaternion.identity);
	}
}
