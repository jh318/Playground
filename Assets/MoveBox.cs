using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {

	Vector3 boxVector;
	public float speed = 3;

	void Start(){
		boxVector = transform.position;
		//StartCoroutine ("moveWait");
	}

	void Update(){
		if (Input.GetKey("right")) {
			boxVector.x += 1.0f * speed;
			transform.position = boxVector;
		}
		if (Input.GetKey ("left")) {
			boxVector.x -= 1.0f * speed;
			transform.position = boxVector;
		}
			
	}
		
	IEnumerator moveWait(){
		while (enabled) {
			boxVector.x += 1.0f * speed;
			transform.position = boxVector;
			//yield return new WaitForSeconds (1);
			yield return new WaitForEndOfFrame();
		}
	}
}
