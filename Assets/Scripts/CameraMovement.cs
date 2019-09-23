using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	float speed = 5f;

	void Update() {
		Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		Vector2 movement = Vector2.zero;
		if (mousePos.x < 0 || mousePos.x > 1 || mousePos.y < 0 || mousePos.y > 1) {
			movement = Vector2.zero;
		}
		else if (mousePos.x < .2 || mousePos.x > .8 || mousePos.y < .2 || mousePos.y > .8) {
			movement = mousePos - Vector2.one * .5f;
		}
		transform.position += new Vector3(movement.x, movement.y, 0f) * Time.deltaTime * speed;
	}
}
