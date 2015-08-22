using UnityEngine;
using System.Collections;

public class TriggerFinger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			//targetInstance = m_Targeting.targetInstance;
			BroadcastMessage ("FireLeft");
		}
		else if(Input.GetButtonDown("Fire2"))
		{
			BroadcastMessage ("FireRight");
		}
	}
}
