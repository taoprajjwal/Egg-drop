using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour {

	public Sprite OffButton;
	public Sprite OnButton;
	private bool Music=true;
	private Button button;


	void Start () {
		button = GetComponent<Button> ();

	}
	
	public void MusicButtonClick(){
		Music = !Music;

			if (Music == false) {
			button.image.sprite	= OffButton;
		}
			else {

			button.image.sprite=OnButton;
			}

		}
	}

