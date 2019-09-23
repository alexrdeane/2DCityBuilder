using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Building buildingPrefab;
	public BuildingObject[] buildings;

	BuildingObject selectedBuilding;

	void Start() {
		selectedBuilding = buildings[0];
	}

	public void Place(Vector2 position) {
		Instantiate(buildingPrefab, position, Quaternion.identity).buildingObject = selectedBuilding;
	}

	void Update() {
		//if (Input.GetMouseButtonDown(0)) {
		//	Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//	RaycastHit2D hit = Physics2D.Raycast(mousePos, new Vector2(0, .01f), 0.01f);
		//	if (hit) {
		//		if (hit.transform.tag == "Tile") {
		//			Place(hit.transform.position);
		//		}
		//	}
		//}

	}
}