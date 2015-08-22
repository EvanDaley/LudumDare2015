using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class SimpleHuman : MonoBehaviour {

	public Transform hidingSpot;
	private AICharacterControl m_AICharacterControl;

	void Start()
	{
		m_AICharacterControl = GetComponent<AICharacterControl>();
	}

	void FindHidingPlace()
	{
		print("Running scared");

		if(hidingSpot != null)
			m_AICharacterControl.SetTarget (hidingSpot);
	}
}
