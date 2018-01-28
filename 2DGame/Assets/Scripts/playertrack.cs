using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertrack : MonoBehaviour {

	// Use this for initialization
	public Transform playerposition;
	public Vector3 offset;
	
	// Update is called once per frame
	void Start ()
	{
		offset = transform.position - playerposition.transform.position;
	}
	void Update () 
	{

       transform.position=playerposition.position+offset;
	}
}
