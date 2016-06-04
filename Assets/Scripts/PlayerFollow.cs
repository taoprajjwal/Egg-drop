using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {
	public float speed;
	void Start () {
	
	}
	
	void Update () {
		transform.Translate (new Vector2(1,0)*speed* Time.deltaTime);


	
	}


}



