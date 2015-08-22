using UnityEngine;
using System.Collections;

public class CreationCannon : MonoBehaviour, IWeapon {
	
	public string leftOption = "LMB: Place Single Object";
	public string rightOption = "RMB: ";
	
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
	
	public void FireLeft()
	{
		print ("Construction cannon LMB");
	}
	
	public void FireRight()
	{
		print ("Construction cannon RMB");
		m_TargetObject = m_Targeting.targetInstance;
	}
}
