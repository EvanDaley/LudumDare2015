using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class WeaponSwapper : MonoBehaviour {

	public Text weaponName;
	public Text leftHint;
	public Text rightHint;
	
	public float scrollCoolTime = 0f;
	private float scrollDelay = .3f;
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
		ActiveWeaponIndex = weaponIndex;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Alpha1))
			ActiveWeaponIndex = 0;
		else if(Input.GetKeyDown (KeyCode.Alpha2))
			ActiveWeaponIndex = 1;
		else if(Input.GetKeyDown (KeyCode.Alpha3))
			ActiveWeaponIndex = 2;
		else if(Input.GetKeyDown (KeyCode.Alpha4))
			ActiveWeaponIndex = 3;

		if(Time.time < scrollCoolTime)
			return;

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
			scrollCoolTime = Time.time + scrollDelay;

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

		UpdateText();
	}

	public void UpdateText()
	{
		weaponName.text = ActiveWeapon.GetWeaponName ();
		leftHint.text = ActiveWeapon.GetHintLeft ();
		rightHint.text = ActiveWeapon.GetHintRight ();
	}

	public IWeapon ActiveWeapon
	{
		get
		{
			if(ActiveWeaponIndex == 0)
				return weapon1.GetComponent<IWeapon>();
			else if(ActiveWeaponIndex == 1)
				return weapon2.GetComponent<IWeapon>();
			else if(ActiveWeaponIndex == 2)
				return weapon3.GetComponent<IWeapon>();
			else if(ActiveWeaponIndex == 3)
				return weapon4.GetComponent<IWeapon>();

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
