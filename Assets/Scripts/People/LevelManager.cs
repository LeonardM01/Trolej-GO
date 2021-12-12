using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{   
    Bus player;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Bus>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = ("Putnici: " + player.points);
    }
}
