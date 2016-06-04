using UnityEngine;
using System.Collections;

public class SPAWN : MonoBehaviour {
	private Vector3 spawnposition;
	private float xpos;
	private float x;
	public GameObject spawned;


	void Start(){
	}


	void OnBecameInvisible(){

		if (ScoreManager.Score < 10) {
			xpos = Random.Range (10, 15);
		
		}

		else if(ScoreManager.Score>10 && ScoreManager.Score<15){

			xpos=Random.Range(15,17);

		}

		else {
			xpos=17f;
		}
		x = gameObject.transform.position.x;
		spawnposition = new Vector3 (x + xpos, -3.31f, 0f);
		Instantiate (spawned, spawnposition, Quaternion.identity);
		Destroy (gameObject);
	}

}
