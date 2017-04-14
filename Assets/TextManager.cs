using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

	public GameObject textBox;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) {
			if (textBox.gameObject.activeSelf == true)
				textBox.SetActive (false);
			else
				textBox.SetActive (true);
		}
	}
}
