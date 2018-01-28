using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class clickss : MonoBehaviour {

	// Use this for initialization
	public AudioMixer mastermixer;

	public void SetSound (float soundLevel)
	{
		mastermixer.SetFloat("click",soundLevel);
	}

}
