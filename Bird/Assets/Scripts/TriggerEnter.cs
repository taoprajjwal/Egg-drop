using UnityEngine;
using System.Collections;

public class TriggerEnter : MonoBehaviour {
	public float score;	







	void OnTriggerEnter2D(Collider2D Object){
		if (Object.gameObject.tag == "Ground") {
			print ("GAME OVER");
			Destroy (gameObject);
		}

		if (Object.gameObject.tag == "Nest") {

			ScoreManager.Score++;
			Destroy (gameObject);
		}


	}


}
