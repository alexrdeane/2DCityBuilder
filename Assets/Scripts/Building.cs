using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Building : MonoBehaviour {

	public BuildingObject buildingObject;

	SpriteRenderer spriteRenderer;

	Sprite sprite;
	BuildingType buildingType;
	int initialCost;
	int maintainenceCost;
	int people;
	int energyConsumption;
	int happiness;
	int happinessRange;

	void Start() {

		spriteRenderer = GetComponent<SpriteRenderer>();

		sprite = buildingObject.sprite;
		buildingType = buildingObject.buildingType;
		initialCost = buildingObject.initialCost;
		maintainenceCost = buildingObject.maintainenceCost;
		people = buildingObject.people;
		energyConsumption = buildingObject.energyConsumption;
		happiness = buildingObject.happiness;
		happinessRange = buildingObject.happinessRange;

		spriteRenderer.sprite = sprite;

		spriteRenderer.sortingOrder = -(int)Mathf.Floor(transform.position.y*4/0.35f);
		transform.position = new Vector3(transform.position.x, transform.position.y, -spriteRenderer.sortingOrder*0.01f);
	}

	void Update() {

	}
}
