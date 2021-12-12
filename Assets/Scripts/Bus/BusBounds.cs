using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusBounds : MonoBehaviour
{
	private float minX, maxX, minY;

	// Use this for initialization
	void Start () {
		SetMinAndMaxX ();
	}

	void Update() {
		if (transform.position.x < minX) {
			Vector3 temp = transform.position;
			temp.x = minX;
			transform.position = temp;
		}

		if (transform.position.x > maxX) {
			Vector3 temp = transform.position;
			temp.x = maxX;
			transform.position = temp;
		}
        if (transform.position.y < minY) {
			Vector3 temp = transform.position;
			temp.y = minY;
			transform.position = temp;
		}
	}

	void SetMinAndMaxX() {
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, 0));
		
		minX = -bounds.x;
		maxX = bounds.x;
        minY = -bounds.y;
	}
}
