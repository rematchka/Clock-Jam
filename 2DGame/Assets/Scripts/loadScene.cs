using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour {

	public void LoadSceneByIndex(int indx)
	{
		SceneManager.LoadScene (indx);
	} 
}
