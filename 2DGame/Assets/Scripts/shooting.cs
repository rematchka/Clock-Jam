using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public int speed=6;
	public GameObject gameobject;

	void Start () {
		Rigidbody2D rb = gameobject.GetComponent<Rigidbody2D>();
		rb.velocity= new Vector2(speed,0);
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void destory ()
	{
     Destroy(gameobject);
	}
}
