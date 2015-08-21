using UnityEngine;
using System.Collections;

public class SpinControlled : MonoBehaviour {

	private Transform m_Transform;
	public float spinSpeed = 90f;
	public bool rotateAroundFowardAxis = true;

	// Use this for initialization
	void Start () {
		m_Transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(spinSpeed > 0)
		{
			if(rotateAroundFowardAxis)
				m_Transform.RotateAround (m_Transform.position,m_Transform.forward,spinSpeed * Time.deltaTime);
		}
	}
}
