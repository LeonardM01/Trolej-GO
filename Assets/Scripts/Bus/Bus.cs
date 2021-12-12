using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
  public float speed = 5f;
  public float movementx = 0f;
  public Rigidbody2D rigidBody;
  public int points;
  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
  }
  
  // Update is called once per frame
  void FixedUpdate () {
    movementx = Input.GetAxis ("Horizontal");
    if (movementx > 0f) {
      rigidBody.velocity = new Vector2 (movementx * speed, 2.1f);
    }
    else if (movementx < 0f) {
      rigidBody.velocity = new Vector2 (movementx * speed, 2.1f);
    } 
    else {
      rigidBody.velocity = new Vector2 (0 , 2.1f);
    }
 }
} //Player speed on the X

