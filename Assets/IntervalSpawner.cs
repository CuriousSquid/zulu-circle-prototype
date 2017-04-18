using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSpawner : Spawner {

	[SerializeField] float minInterval = 1f;
	[SerializeField] float maxInterval = 2f;

	// Use this for initialization
	void Start () {
		StartCoroutine ("DoIntervalSpawn");
	}
	
	IEnumerator DoIntervalSpawn() {
		for (;;) {
			Spawn ();
			yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));
		}
	}
}
