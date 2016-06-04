﻿using UnityEngine;
using System.Collections;

public class TriggerEnter : MonoBehaviour {
	public float score;	







	void OnTriggerEnter2D(Collider2D Object){
		if (Object.gameObject.tag == "Ground") {
			Application.LoadLevel(2);
			Destroy (gameObject);
		}

		if (Object.gameObject.tag == "Nest") {

			ScoreManager.Score++;
			Destroy (gameObject);
		}


	}


}