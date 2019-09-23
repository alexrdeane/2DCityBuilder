using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	void Start() {
		
	}

	void Update() {
		Debug.Log(Input.mousePosition.x);
		Debug.Log(Input.mousePosition.y);
	}
}
