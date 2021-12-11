using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMovement : MonoBehaviour
{

	public float speed = 8f, maxVelocity = 4f, maxVelocityY = 1f;
	private Rigidbody2D myBody;

	private bool moveLeft, moveRight, moveUp;
	
	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		if (moveLeft) {
			MoveLeft();
		}

		if (moveRight) {
			MoveRight();
		}
		if (moveUp){
			MoveUp();
		}
	}

	public void SetMoveLeft(bool moveLeft) {
		this.moveLeft = moveLeft;
		this.moveRight = !moveLeft;
	}

	public void StopMoving() {
		moveLeft = moveRight = false;
	}

	void MoveLeft() {

		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);

		if (vel < maxVelocity)
			forceX = -speed;
		
		Vector3 temp = transform.localScale;
		temp.x = 1f;
		transform.localScale = temp;


		myBody.AddForce (new Vector2(forceX, 0));

	}

	void MoveRight() {

		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);
		
		if (vel < maxVelocity)
			forceX = speed;
		
		Vector3 temp = transform.localScale;
		temp.x = 1f;
		transform.localScale = temp;

		
		myBody.AddForce (new Vector2(forceX, 0));

	}

	void MoveUp(){

		float forceY = 0f;
		float vel = Mathf.Abs (myBody.velocity.y);
		
		if (vel < maxVelocityY)
			forceY = speed;
		
		Vector3 temp = transform.localScale;
		temp.y = 1f;
		transform.localScale = temp;

		
		myBody.AddForce (new Vector2(0, forceY));

	}


}
