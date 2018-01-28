using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokill : MonoBehaviour {

	// Use this for initialization
	//public Transform m_muzzle;
	public GameObject m_shotPrefab;
	public Transform m_muzzle;
	int health=30;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject go = GameObject.Instantiate(m_shotPrefab, m_muzzle.position, m_muzzle.rotation) as GameObject;
			GameObject.Destroy(go, 3f);
		}
		
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			health -= 5;
			if (health <= 0)
				Destroy (gameObject);
		} else if (other.gameObject.tag == "bullet") {
			health -= 10;
			if (health <= 0)
				Destroy (gameObject);
			Destroy(other.gameObject);
		}
	}
}
