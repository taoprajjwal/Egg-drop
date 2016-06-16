using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour {

	public Sprite OffButton;
	public Sprite OnButton;
	private bool Music=true;
	private Button button;
	public GameObject AppMan;



	void Start () {
		button = GetComponent<Button> ();
		AppMan = GameObject.Find ("ApplicationManagers");
	}

	public void MusicButtonClick(){
		Music = !Music;

			if (Music == false) {
			button.image.sprite	= OffButton;
			ApplicationManager Appmans=AppMan.GetComponent<ApplicationManager>();
			Appmans.ToggleMusic (Music);

		}
			else {

			button.image.sprite=OnButton;
			ApplicationManager Appmans=AppMan.GetComponent<ApplicationManager>();
			Appmans.ToggleMusic (true);
			}

		}
	}

