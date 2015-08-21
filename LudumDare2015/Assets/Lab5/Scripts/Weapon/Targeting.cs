using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour {

	public Vector3 target;
	public Transform targetTransform;

	private Ray ray;
	private RaycastHit hit;

	private Transform m_Transform;

	public bool debug = false;

	// Use this for initialization
	void Start () {
		m_Transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		ray = new Ray(m_Transform.position, Camera.main.transform.forward);

		if(Physics.Raycast (ray, out hit,15))
		{
			target = hit.point;
			targetTransform = hit.transform;

			if(debug)
				Debug.Log ("We hit: " + targetTransform);
		}
	}
}
