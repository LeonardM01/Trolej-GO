using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleCollector : MonoBehaviour
{   
  
	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "People") {
			target.gameObject.SetActive(false);
		}
	}
}
