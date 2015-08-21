using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class WeaponSwapper : MonoBehaviour {

	private Text leftHint;
	private Text rightHint;

	public float scrollDelay = .1f;
	public int weaponIndex = 0;

	// if we want to enable more than 4 weapons we could do it generically
	//public List<GameObject> weaponList;

	// static method
	public GameObject weapon1;
	public GameObject weapon2;
	public GameObject weapon3;
	public GameObject weapon4;

	public bool debugMode = false;

	// Use this for initialization
	void Start () {
		ActiveWeaponIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse ScrollWheel") > .05)
		{
			ActiveWeaponIndex ++;
			print ("Scroll up");
		}
		else if(Input.GetAxis("Mouse ScrollWheel") < -.05)
		{
			ActiveWeaponIndex --;
			print ("Scroll down");
		}
	}

	public int ActiveWeaponIndex
	{
		get{return weaponIndex;}
		set
		{
			HideWeapons();
			weaponIndex = value;
			if(weaponIndex < 0)
				weaponIndex = MaxWeaponIndex;

			if(weaponIndex > MaxWeaponIndex)
				weaponIndex = 0;

			DrawWeapon (weaponIndex);
		}
	}

	public void HideWeapons()
	{
		if(weapon1 != null)
			weapon1.SetActive (false);

		if(weapon2 != null)
			weapon2.SetActive (false);

		if(weapon3 != null)
			weapon3.SetActive (false);

		if(weapon4 != null)
			weapon4.SetActive (false);
	}

	public void DrawWeapon(int weaponIndex)
	{
		if(weaponIndex == 0 && weapon1 != null)
		{
			weapon1.SetActive (true);
			if(debugMode)
				print ("Weapon 1 active");
		}

		else if(weaponIndex == 1 && weapon2 != null)
		{
			weapon2.SetActive (true);
			if(debugMode)
				print ("Weapon 2 active");
		}

		else if(weaponIndex == 2 && weapon3 != null)
			weapon3.SetActive (true);

		else if(weaponIndex == 3 && weapon4 != null)
		   	weapon4.SetActive (true);
	}

	public GameObject ActiveWeapon
	{
		get
		{
			//get weapon at index
			return null;
		}
	}

	public int MaxWeaponIndex
	{
		get
		{
			//for infinite weapon slots
			//calculate number of equipped weapons
			//return size of array
			return 3;
		}
	}
}
