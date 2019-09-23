using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	GameManager gameManager;

	void Start() {
		if (!gameManager) gameManager = FindObjectOfType<GameManager>();
	}
	void OnMouseDown() {
		Debug.Log("A");
		gameManager.Place(transform.position);
	}
	void Update() {

	}
}
