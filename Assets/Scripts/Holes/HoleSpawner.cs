using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawner : MonoBehaviour
{
 [SerializeField]
   private GameObject holes;
    public GameObject spawnerRoom;
   void Start(){
       SpawnHoles();
   }

    public void SpawnHoles(){
        spawnerRoom = GameObject.FindGameObjectWithTag("MainCamera");
        bool holesSpawned = false;
        while (!holesSpawned){
            Vector3 holePosition = new Vector3(Random.Range(spawnerRoom.transform.position.x-2f, spawnerRoom.transform.position.x+2f),Random.Range(spawnerRoom.transform.position.y+10f, spawnerRoom.transform.position.y+20f), -1f);
            if ((holePosition - transform.position).magnitude < 3){
                continue;
            }
            else {
                Instantiate(holes, holePosition, Quaternion.identity);
                holesSpawned = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(collision.gameObject);
        SpawnHoles();
    }

}
