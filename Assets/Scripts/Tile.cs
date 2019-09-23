using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public bool placeable = true;

	GameManager gameManager;
	SpriteRenderer spriteRenderer;

	void Start() {
		spriteRenderer = GetComponent<SpriteRenderer>();
		if (!gameManager) gameManager = FindObjectOfType<GameManager>();
		spriteRenderer.sortingOrder = -(int)Mathf.Floor(transform.position.y * 4f / 0.35f+1f);
		transform.position = new Vector3(transform.position.x, transform.position.y, -spriteRenderer.sortingOrder * 0.01f);
	}
	void OnMouseDown() {
		gameManager.Place(transform.position);
	}
	void Update() {

	}
}
