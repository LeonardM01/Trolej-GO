using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public GameObject bus;
    public float posOfBus;
    public float posOfTouch;

    Vector3 inWorldPos = new Vector3();
    private float speed = 4f;
    private float? tempPosOld;
    private float tempPosNew;
    // Start is called before the first frame update
    void Start()
    {
        bus = GameObject.Find("bus");
    }

    // Update is called once per frame
    void Update()
    {
        posOfBus = bus.transform.position.x;
        // If pressed with one finger
        if (Input.GetMouseButtonDown(0))
             tempPosOld = Input.touches[0].position.x;
 
        else if (Input.GetMouseButtonUp(0))
            tempPosOld = null;

        if (Input.touchCount > 0)
            inWorldPos = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
        
        posOfTouch = inWorldPos.x;

        if (tempPosOld != null)
        {
            tempPosNew = Input.touches[0].position.x;
            // The finger of initial press is now left of the press position
            if (tempPosNew < tempPosOld)
                Move(-speed);

            // The finger of initial press is now right of the press position
            else if (tempPosNew > tempPosOld)
                Move(speed);
            else if (posOfTouch+0.005f == posOfBus-0.005f)
                Move(0);
        }
    }
    //function which moves the player
    private void Move(float velocity)
    {
        transform.position += Vector3.right * velocity * Time.deltaTime;
    }
}
