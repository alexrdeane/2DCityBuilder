using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 2f); // Movement speed
    public Vector2 targetPosition; // The position that has been clicked
    public Vector2 relativePosition; // The position relative to the players current position, what direction and how far did you click
    private Vector2 movement; // Stores the movement
   // public Rigidbody2D rigid;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // The position of the mouse click
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        // Find the relative position of the target based upon the current position
        // Update each frame to account for anymovement
        relativePosition = new Vector2(targetPosition.x - gameObject.transform.position.x, targetPosition.y - gameObject.transform.position.y);
    }

    void FixedUpdate()
    {
        if (speed.x * Time.deltaTime >= Mathf.Abs(relativePosition.x))
        {
            movement.x = relativePosition.x;
        }
        if (speed.y * Time.deltaTime >= Mathf.Abs(relativePosition.y))
        {
            movement.y = relativePosition.y;
        }
        else
        {
            movement.y = speed.y * Mathf.Sign(relativePosition.y);
        }
        //rigid.velocity = movement;
    } 
}
