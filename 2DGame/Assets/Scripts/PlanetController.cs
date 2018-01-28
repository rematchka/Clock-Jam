using UnityEngine;
using System.Collections;

public class PlanetController : MonoBehaviour {
    Vector3 pos;
    public float minPos = -7.0f, maxPos = 10.0f, counter = 3.0f;
    public GameObject planet;


	// Use this for initialization
	void Start ()
    {
        pos = new Vector3(5.0f, 2.24f, -18);
        Instantiate(planet, pos, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position -= new Vector2(0, 1, 0) * Time.deltaTime;
        counter += Time.deltaTime;
        if (counter > 3)
        {
            Spawn();
            counter = 0.0f;
        }
    }

    void Spawn()
    {
        pos = new Vector3(Random.Range(minPos, maxPos), 2, 0);
        Instantiate(planet, pos, Quaternion.identity);
    }
}
