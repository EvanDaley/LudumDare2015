using UnityEngine;
using System.Collections;

public class DeconstructionCannon : MonoBehaviour, IWeapon {

	public string leftOption = "LMB: Select objects to destroy";
	public string rightOption = "RMB: Destroy";

	//public bool equipped = false;

	public GameObject targetInstance;

	private Targeting m_Targeting;

	// Use this for initialization
	void Start () {
		m_Targeting = GetComponent<Targeting>();
	}
	
	// Update is called once per frame
	void Update () {
		//if(equipped)
		{
			if(Input.GetButtonDown("Fire1"))
			{
				//targetInstance = m_Targeting.targetInstance;
			}
			else if(Input.GetButtonDown("Fire2"))
			{
				targetInstance = m_Targeting.targetInstance;
				Destroy (targetInstance);
			}
		}
	}

	public string GetHintLeft()
	{
		return leftOption;
	}

	public string GetHintRight()
	{
		return rightOption;
	}
}
