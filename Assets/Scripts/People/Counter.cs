using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{   
    Bus player;
    public int points;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Bus>();
    }

    void OnTriggerEnter2D(Collider2D hit) {
        if (hit.CompareTag("Player"))
        {
            player.points += 1;
            if(hit.tag == "People"){
            hit.gameObject.SetActive(false);
            }
        }
    }
}
