using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {
	private Light myLight;
	public GameObject gameobject;
	// Use this for initialization
	void Start () {
		
		myLight = gameobject.GetComponent<Light>();
		myLight.enabled = false; 

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
	}
}
