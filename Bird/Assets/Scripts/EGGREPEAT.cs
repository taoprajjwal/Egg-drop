using UnityEngine;
using System.Collections;

public class EGGREPEAT : MonoBehaviour {
	private Vector3 ppos;
	private Vector3 egpos;
	private GameObject eggspawned;
	private int n;
	private GameObject clone;

	void Start () {
		eggspawned = GameObject.Find ("egg100");
		 
	}
	
		void Update () {
		ppos = GameObject.Find ("Player").transform.position;

	
		egpos = new Vector3 (ppos.x, ppos.y - 1, ppos.z); 

		if (Input.GetMouseButtonDown (0)) {
			clone = Instantiate (eggspawned, egpos, Quaternion.identity) as GameObject;
			clone.AddComponent<TriggerEnter> ();


		}
	
	}
}
