
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="deadly")
        {
            FindObjectOfType<LevelManager>().EndGame();
            Destroy(collision.gameObject);
        }
    }
}
