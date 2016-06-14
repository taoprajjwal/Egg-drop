using UnityEngine;
using System.Collections;

public class MusicAwake : MonoBehaviour {

	private AudioSource BgMusic;

	void Start(){
		BgMusic = GetComponent<AudioSource> ();
	}

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	public void Muted(){
		BgMusic.mute = true;
	}


}