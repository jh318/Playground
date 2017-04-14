using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public Canvas textBox;
	public Text testString;
	public string testText = "Hello World";


	// Use this for initialization
	void Start () {
		//testString.text = testText;
		StartCoroutine("PrintString");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up")) {
			if (textBox.gameObject.activeSelf == true)
				textBox.gameObject.SetActive (false);
			else
				textBox.gameObject.SetActive (true);
		}
	}

	IEnumerator PrintString(){
		for (int i = 0; i < testText.Length; i++) {
			//testString.text = testString.text[i];
			testString.text += testText[i];
			yield return new WaitForSeconds(0.20f);
		}
	}
}
