using UnityEngine;
using System.Collections;

public class MusicAwake : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
}