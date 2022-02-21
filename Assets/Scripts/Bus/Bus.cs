using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public Rigidbody2D myBody;
    public int points;
    private float speed = 2f;
    private float acceleration = 0.2f;
    private float maxSpeed = 2f;

    [HideInInspector]
    public bool moveBusWithCamera1;

    // Use this for initialization
    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    
    void Start() {
        moveBusWithCamera1 = true;
    }

    /// Called once every frame
    void Update()
    {
        if (moveBusWithCamera1)
        {
            speed=moveBusWithCamera();
        }
        myBody.velocity = new Vector3(0, speed, 0);
    }

    private float moveBusWithCamera()
    {
        speed += acceleration * Time.deltaTime;

        if (speed > maxSpeed)
            speed = maxSpeed;

        return speed;
    }
} 

