using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeconstructionCannon : MonoBehaviour, IWeapon {

	public GameObject bloodSplatter1;

	public string weaponName = "Molecular Deconstruction Canon";
	public string leftOption = "LMB: Select objects to destroy";
	public string rightOption = "RMB: Destroy";
	
	public GameObject m_TargetObject;
	private Targeting m_Targeting;

	public List<GameObject> selectedObjects;

	public AudioClip noise;

	private AudioSource musicSource;				//Reference to the AudioSource which plays music

	// Use this for initialization
	void Start () {
		m_Targeting = GetComponent<Targeting>();
		selectedObjects = new List<GameObject>();

		musicSource = GetComponent<AudioSource> ();
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
		if(m_Targeting.targetInstance.tag == "Invincible")
			return;

		print ("Destruction cannon LMB");

		selectedObjects.Add (m_Targeting.targetInstance);

		Renderer [] renderers = m_Targeting.targetInstance.GetComponentsInChildren<Renderer>();

		foreach(Renderer ren in renderers)
		{
			ren.material.color = Color.clear;
		}

		//Play the music clip at the array index musicChoice
		musicSource.clip = noise;
		
		//Play the selected clip
		musicSource.Play ();
	}

	public void FireRight()
	{
		if(selectedObjects.Count == 0)
		{
			Deconstruct (m_Targeting.targetInstance);
		}
		else
		{
			foreach(GameObject ob in selectedObjects)
			{
				Deconstruct (ob);
			}

			selectedObjects = new List<GameObject>();
		}

		//Play the music clip at the array index musicChoice
		musicSource.clip = noise;
		
		//Play the selected clip
		musicSource.Play ();
	}

	public void Deconstruct(GameObject killOb)
	{
		if(killOb != null)
		{
			if(killOb.tag == "Human")
				GameObject.Instantiate (bloodSplatter1,killOb.transform.position + new Vector3(0,1,0),Quaternion.identity);
			
			if(killOb.tag != "Invincible")
				Destroy (killOb);
		}
	}
}
