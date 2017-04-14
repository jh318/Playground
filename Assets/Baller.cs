using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baller : MonoBehaviour {

	public GameObject ball;

	void Start(){
		StartCoroutine ("SpawnBalls");
	}

	IEnumerator SpawnBalls(){
		float x = 0;
		while (enabled) {
			Instantiate (ball, new Vector3 (x, 0, 0), Quaternion.identity);
			x += 3.0f;
			yield return new WaitForSeconds (3);
		}
	}
}
