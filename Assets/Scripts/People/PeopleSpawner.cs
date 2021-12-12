using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{
   [SerializeField]
   private GameObject people;
    public GameObject spawnerRoom;
   void Start(){
       SpawnPeople();
   }

    public void SpawnPeople(){
        spawnerRoom = GameObject.FindGameObjectWithTag("MainCamera");
        bool peopleSpawned = false;
        while (!peopleSpawned){
            Vector3 peoplePosition = new Vector3(Random.Range(spawnerRoom.transform.position.x-2f, spawnerRoom.transform.position.x+2f),Random.Range(spawnerRoom.transform.position.y+10f, spawnerRoom.transform.position.y+20f), -1f);
            if ((peoplePosition - transform.position).magnitude < 3){
                continue;
            }
            else {
                Instantiate(people, peoplePosition, Quaternion.identity);
                peopleSpawned = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(collision.gameObject);
        SpawnPeople();
    }

}
