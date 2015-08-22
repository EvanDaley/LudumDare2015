using UnityEngine;
using System.Collections;

public class LoadNextLevel_TriggerBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter()
	{
		Invoke ("LoadLevel",2f);
	}

	void LoadLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
