using UnityEngine;
using System.Collections;

public class MassModifier : MonoBehaviour, IWeapon {
	
	public string weaponName = "Molecular Modifier";
	public string leftOption = "LMB: Select an Object";
	public string rightOption = "RMB: Deselect";
	
	public GameObject m_TargetObject;
	public Vector3 m_TargetPoint;
	public Vector3 m_HitNormal;
	private Targeting m_Targeting;
	
	// Use this for initialization
	void Start () {
		m_Targeting = GetComponent<Targeting>();
	}
	
	public string GetHintLeft()
	{
		return leftOption;
	}
	
	public string GetHintRight()
	{
		return rightOption;
	}
	public string GetWeaponName()
	{
		return weaponName;
	}
	
	public void FireLeft()
	{
		// select an object
	}
	
	public void FireRight()
	{
		m_TargetObject = m_Targeting.targetInstance;

		// deselect
	}
}
