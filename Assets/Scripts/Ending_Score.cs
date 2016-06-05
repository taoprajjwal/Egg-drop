using UnityEngine;
using System.Collections;

public class Ending_Score : MonoBehaviour {

	public Sprite[] SpritesofNumbers;
	public SpriteRenderer Units, Tens;
	int score=ScoreManager.Score;
	void Start () {
	
		if (score < 10) {
			Units.sprite = SpritesofNumbers [score];
		}
		else if (score >= 9) {
			Tens.sprite = SpritesofNumbers [score / 10];
			Units.sprite = SpritesofNumbers [score % 10];
		

		}
	}
	

}
