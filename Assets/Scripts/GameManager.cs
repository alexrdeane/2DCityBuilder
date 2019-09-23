using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Building buildingPrefab;
	public GameObject tilePrefab;
	public BuildingObject[] buildings;

	public int gold;
	public int people;

	public Text goldText;
	public Text peopleText;
	public Image selectedBuildingImage;

	int selectedIndex = 0;
	BuildingObject selectedBuilding;

	void Awake() {
		gold = 200;
	}

	void Start() {
		selectedBuilding = buildings[selectedIndex];

		SpawnTiles();
	}

	void SpawnTiles() {
		for (int x = -5; x <= 5; x++) {
			for (int y = -20; y <= 20; y++) {
				float x2 = x;
				if (y % 2 == 0) x2 += .5f;
				Instantiate(tilePrefab, new Vector3(x2, y*0.35f*.5f, 0f), Quaternion.identity);
			}
		}
	}

	public void Place(Vector2 position) {
		if (gold >= selectedBuilding.initialCost) {
			Instantiate(buildingPrefab, position, Quaternion.identity).buildingObject = selectedBuilding;
			gold -= selectedBuilding.initialCost;
			people += selectedBuilding.people;
			goldText.text = gold.ToString();
			peopleText.text = people.ToString();
		}
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			selectedIndex = (selectedIndex - 1 + buildings.Length) % buildings.Length;
			selectedBuilding = buildings[selectedIndex];
			selectedBuildingImage.sprite = selectedBuilding.sprite;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			selectedIndex = (selectedIndex + 1) % buildings.Length;
			selectedBuilding = buildings[selectedIndex];
			selectedBuildingImage.sprite = selectedBuilding.sprite;
		}
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