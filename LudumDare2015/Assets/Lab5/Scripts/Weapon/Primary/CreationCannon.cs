using UnityEngine;
using System.Collections;

public class CreationCannon : MonoBehaviour, IWeapon {

	public string weaponName = "Molecular Construction Cannon";
	public string leftOption = "LMB: Place Carbon-Based Object";
	public string rightOption = "RMB: Place 10101011010011 Object";
	
	public GameObject m_TargetObject;
	public Vector3 m_TargetPoint;
	public Vector3 m_HitNormal;
	private Targeting m_Targeting;

	private GameObject creation;
	public GameObject carbonPrefab;

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
		creation = CreateObject();
	}
	
	public void FireRight()
	{
		creation = CreateObject();
		SnapToGrid (creation.transform);
	}

	public GameObject CreateObject()
	{
		if(m_Targeting.targetInstance == null)
			m_Targeting.target = Camera.main.transform.position + Camera.main.transform.forward*m_Targeting.range;

		GameObject obj = GameObject.Instantiate(carbonPrefab, m_Targeting.target, Quaternion.identity) as GameObject;
		obj.transform.position = Vector3.MoveTowards (obj.transform.position,transform.position,.5f);

		return obj;
	}

	private void SnapToGrid(Transform ob)
	{
		float mx = ob.position.x;
		float my = ob.position.y;
		float mz = ob.position.z;

		mx = (float)System.Math.Round((double)mx, 0, System.MidpointRounding.AwayFromZero);
		my = (float)System.Math.Round((double)my, 0,  System.MidpointRounding.AwayFromZero);
		mz = (float)System.Math.Round((double)mz, 0,  System.MidpointRounding.AwayFromZero);

		ob.transform.position = new Vector3(mx,my,mz);
	}
}
