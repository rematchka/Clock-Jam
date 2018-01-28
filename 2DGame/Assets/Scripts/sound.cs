using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class sound : MonoBehaviour {

	// Use this for initialization
	public AudioMixer mastermixer;

	public void SetSound (float soundLevel)
	{
		mastermixer.SetFloat("hello",soundLevel);
	}

}
