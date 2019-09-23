using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	void Start() {

	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D[] hits = Physics2D.RaycastAll(mousePos, new Vector2(0, 0), 0.01f);
			foreach (RaycastHit2D hit in hits) {

			}
		}
	}
}