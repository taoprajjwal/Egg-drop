using UnityEngine;
using System.Collections;

public class Ending_Score : MonoBehaviour {

	public Sprite[] SpritesofNumbers;
	public SpriteRenderer Units, Tens, Hundreds;
	void Start () {
	
		Units.sprite = SpritesofNumbers [0];
	}
	

}
