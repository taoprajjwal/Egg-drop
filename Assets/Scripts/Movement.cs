using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public static float speed{ get; set;}
	void Start () {

	}
	
	void Update () {
		transform.position += Vector3.right * Time.deltaTime*speed;
		speed = 4+(ScoreManager.Score/5f);

	}
}
