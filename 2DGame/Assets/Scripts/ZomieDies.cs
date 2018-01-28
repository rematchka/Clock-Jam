using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomieDies : MonoBehaviour {

	// Use this for initialization
	int health=30;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (health <= 0) {

			
			Destroy(gameObject);
			}
		
	}


	void OnTriggerEnter2D (Collider2D other)
	{  
           GameObject girl= GameObject.FindGameObjectWithTag("Girl");
          //  GameObject.FindGameObjectsWithTag("Girl"); 

		GameObject bullet=GameObject.FindGameObjectWithTag("Bullet");   
	  
		if (other.gameObject== girl) {

			health -= 5;
		

		} else if (other.gameObject == bullet) {
			health -= 10;
			  
			Destroy(bullet);
			Debug.Log("being Killed");

		}
	}

}
