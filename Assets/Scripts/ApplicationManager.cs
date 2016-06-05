using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
	
	private int t;	
	public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
		

	public void play()
	{
		ScoreManager.Score = 0;
		UnityEngine.SceneManagement.SceneManager.LoadScene (1, UnityEngine.SceneManagement.LoadSceneMode.Single);	

		}



	
}



