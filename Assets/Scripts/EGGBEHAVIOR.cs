using UnityEngine;
using System.Collections;

public class EGGBEHAVIOR : MonoBehaviour {

	public GameObject replicatedball;
	private Vector3 ppos;
	private float x;
	private float y;
	private float z;
	private Vector3 egpos;

	// Use this for initialization
	void Start () {
		replicatedball = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
		ppos = GameObject.Find ("Player").transform.position;


		egpos = new Vector3 (ppos.x, ppos.y - 1, ppos.z); 


		if (Input.GetMouseButtonDown (0)) {

			gameObject.transform.position = new Vector3 (egpos.x, egpos.y - 1, egpos.z);

		}
	}
}
