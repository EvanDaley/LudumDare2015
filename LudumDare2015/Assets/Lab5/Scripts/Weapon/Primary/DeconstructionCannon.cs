using UnityEngine;
using System.Collections;

public class DeconstructionCannon : MonoBehaviour, IWeapon {

	public GameObject bloodSplatter1;

	public string weaponName = "Molecular Deconstruction Canon";
	public string leftOption = "LMB: Select objects to destroy";
	public string rightOption = "RMB: Destroy";
	
	public GameObject m_TargetObject;
	private Targeting m_Targeting;

	// Use this for initialization
	void Start () {
		m_Targeting = GetComponent<Targeting>();
	}

	public string GetWeaponName()
	{
		return weaponName;
	}

	public string GetHintLeft()
	{
		return leftOption;
	}

	public string GetHintRight()
	{
		return rightOption;
	}

	public void FireLeft()
	{
		print ("Destruction cannon LMB");
	}

	public void FireRight()
	{
		print ("Destruction cannon RMB");
		m_TargetObject = m_Targeting.targetInstance;

		if(m_TargetObject == null)
			return;

		if(m_TargetObject.tag == "Human")
			GameObject.Instantiate (bloodSplatter1,m_Targeting.target,Quaternion.identity);


		if(m_TargetObject.tag != "Invincible")
			Destroy (m_TargetObject);
	}
}
