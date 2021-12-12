using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    bool gameHasEnded = false;
    public float restartDelay = 1f;

       public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            
            Invoke("Restart",restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
