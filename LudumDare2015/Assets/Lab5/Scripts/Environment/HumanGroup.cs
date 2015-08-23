using UnityEngine;
using System.Collections;

public class HumanGroup : MonoBehaviour {

	public int humanCount;
	private bool humanDead = false;

	// Use this for initialization
	void Start () {
		humanCount = transform.childCount;
	}
	
	// Update is called once per frame
	void Update () {
		if(!humanDead)
		{
			if(transform.childCount != humanCount)
			{
				print ("Update human count: " + humanCount);
				print ("Update child count: " + transform.childCount);

				humanDead = true;

				if(transform.childCount != 0)
					BroadcastMessage("FindHidingPlace");
			}
		}
	}
}
