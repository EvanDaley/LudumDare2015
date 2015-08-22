using UnityEngine;
using System.Collections;

public class AlienHardDrive : MonoBehaviour, IWeapon {
	
	public string weaponName = "Alien Scanner";
	public string leftOption = "LMB: Select Blocks";
	public string rightOption = "RMB: Copy Molecular Formations Into Digital Memory";
	
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
		print ("Scanner LMB");
	}
	
	public void FireRight()
	{
		print ("Scanner RMB");
		m_TargetObject = m_Targeting.targetInstance;
	}
}
