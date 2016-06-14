using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
	
	public static bool hover=false;

	// Begin States
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

	public void pause(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (3, UnityEngine.SceneManagement.LoadSceneMode.Single);
	}

	public void playonresume(){
		hover = false;
		UnityEngine.SceneManagement.SceneManager.LoadScene (1, UnityEngine.SceneManagement.LoadSceneMode.Single);	

	}


	 
	public void OnHover(){

		hover = true;
		}

	public void OuterHover(){

		hover = false;
	}
}



