using UnityEngine;
using System.Collections;

public class BGLOOP : MonoBehaviour {
	private Vector3 backpos;
	public float width;
	private float x;
	private float y;


	void OnBecameInvisible(){

		backpos = gameObject.transform.position;

		x = backpos.x + width * 2;
		y = backpos.y;

		gameObject.transform.position = new Vector3 (x, y, 0f);
	}


	}

