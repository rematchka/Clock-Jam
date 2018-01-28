using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour {

	// Use this for initialization
	public GameObject girl;
	public Text playerHealth;

	int h;
	// Update is called once per frame
	void Update () {
		    int h=girl.GetComponent<PlayerController>().health;
		    if(h<0) h=0;
            playerHealth.text =h.ToString();
	}
}
