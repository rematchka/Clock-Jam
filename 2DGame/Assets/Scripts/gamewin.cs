using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamewin : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
	                   
		if (other.gameObject.tag == "Girl") 
		{
			SceneManager.LoadScene (4);
		}
	}
	
	// Update is called once per frame
	void Update () {



	}
}
