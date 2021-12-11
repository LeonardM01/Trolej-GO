using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
   public float speed = 8f, maxVelocity = 4f;
	private Rigidbody2D myBody;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
	}

	void Start () {
	
	}

	void FixedUpdate () {
		BusKeyboard ();
	}

	void BusKeyboard() {
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0) {

			if (vel < maxVelocity)
				forceX = speed;

			Vector3 temp = transform.localScale;
			temp.x = 0.4f;
			transform.localScale = temp;

		} else if (h < 0) {
		
			if (vel < maxVelocity)
				forceX = -speed;
			
			Vector3 temp = transform.localScale;
			temp.x = 0.4f;
			transform.localScale = temp;


		}


		myBody.AddForce (new Vector2(forceX, 0));

	}

} //Player speed on the X

