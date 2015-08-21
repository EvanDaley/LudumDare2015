using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour {

	public Vector3 target;
	public GameObject targetInstance;

	private Ray ray;
	private RaycastHit hit;

	private Transform mainCamera;

	public bool debug = false;
	public LayerMask layerMask;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		ray = new Ray(mainCamera.position, mainCamera.forward);

		if(Physics.Raycast (ray, out hit,15,layerMask))
		{
			target = hit.point;
			targetInstance = hit.transform.gameObject;

			if(debug)
				Debug.Log ("We hit: " + targetInstance);
		}
	}
}
