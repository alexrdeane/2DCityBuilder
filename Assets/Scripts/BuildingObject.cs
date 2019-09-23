using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingObject", menuName = "BuildingObject", order = 51)]
public class BuildingObject : ScriptableObject {
	public Sprite sprite;
	public BuildingType buildingType;
	public int initialCost;
	public int maintainenceCost;
	public int people;
	//public int energyConsumption;
	//public int happiness;
	//public int happinessRange;
}

public enum BuildingType {
	House,
	Shop,
	Entertainment,
	Powerplant
}