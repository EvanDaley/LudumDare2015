using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class SimpleHuman : MonoBehaviour {

	public Transform hidingSpot;
	private AICharacterControl m_AICharacterControl;
	private ThirdPersonCharacter m_character;

	void Start()
	{
		m_AICharacterControl = GetComponent<AICharacterControl>();
		m_character = GetComponent<ThirdPersonCharacter>();

	}

	void FindHidingPlace()
	{
		print("Running scared");

		if(hidingSpot != null)
			m_AICharacterControl.SetTarget (hidingSpot);
	}

	void Update()
	{
		float distance = 10000f;

		distance = Vector3.Distance (transform.position,hidingSpot.position);
		if(distance < 5)
			m_character.m_Crouching = true;
	}

}
