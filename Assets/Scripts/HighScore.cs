using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	public Sprite[] HighScoreSprites;
	public SpriteRenderer Units, Tens;


	void Start () {
		int score=PlayerPrefs.GetInt("HighScore");

		print(PlayerPrefs.GetInt("HighScore"));
		if (score < 10) {
			Units.sprite = HighScoreSprites [score];
		}
		else if (score >= 10) {
			Tens.sprite = HighScoreSprites [score / 10];
			Units.sprite = HighScoreSprites [score % 10];


		}
	}
}
