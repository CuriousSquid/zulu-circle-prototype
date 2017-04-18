using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingSpawner : Spawner {

	[SerializeField] GameObject orbitCentre;
	[SerializeField] float speed = 10f;
	[SerializeField] float timeBetweenSpawns = 1f;
	float timeSinceLastSpawn;

	// Use this for initialization
	void Start () {
		StartCoroutine ("DoOrbitSpawn");
		timeSinceLastSpawn = timeBetweenSpawns;
	}

	void FixedUpdate() {
		timeSinceLastSpawn += Time.fixedDeltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) {
			timeSinceLastSpawn = 0f;
			Spawn();
		}

		transform.RotateAround (orbitCentre.transform.position, Vector3.forward, Time.fixedDeltaTime * speed);
	}
}
