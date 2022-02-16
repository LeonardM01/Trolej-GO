using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    private Rigidbody2D myBody;
    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start() {
        myBody.velocity = new Vector3(0,0,0); 
    }
    // Update is called once per frame
    void Update()
    {
     if (Input.touchCount == 1)
        {
            Touch touch0 = Input.GetTouch(0);
 
            if (touch0.phase == TouchPhase.Moved)
            {
                myBody.transform.Translate(touch0.deltaPosition.x*0.09f, 0f, 0f);
            }
 
        }
    }
}
