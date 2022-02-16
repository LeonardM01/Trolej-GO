using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
  public Rigidbody2D myBody;
  public int points;
  public float currentX;
  // Use this for initialization
  void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start() {
        myBody.velocity = new Vector3(0,1.5f,0); 
    }
       /// Movement speed units per second
    [SerializeField]
    private float speed;
    private float stop=0;

    /// X coordinate of the initial press
    // The '?' makes the float nullable
    private float? pressX;

    /// Called once every frame
    private void Update()
    {
        // If pressed with one finger
        if(Input.GetMouseButtonDown(0))
            pressX = Input.touches[0].position.x;
        else if (Input.GetMouseButtonUp(0))
            pressX = null;


        if(pressX != null)
        {
            currentX = Input.touches[0].position.x;
            Vector2 positionBody = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            float positionBodyX = positionBody.x;
            // The finger of initial press is now left of the press position
            if(currentX < pressX && positionBodyX!=myBody.position.x)
                Move(-speed);

            // The finger of initial press is now right of the press position
            else if(currentX > pressX && positionBodyX!=myBody.position.x)
                Move(speed);
            if(positionBodyX==myBody.position.x)
               Move(stop);
            // else is not required as if you manage (somehow)
            // move you finger back to initial X coordinate
            // you should just be staying still
        }
    }
    /// Moves the player
    private void Move(float velocity)
    {
        transform.position += Vector3.right * velocity * Time.deltaTime;
    }

} //Player speed on the X

