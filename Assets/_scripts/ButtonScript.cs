using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	/// <summary>
	/// Performs some of the button functionalities. 
	/// </summary>
	public void GameScreen() {
		SceneManager.LoadScene ("GameScreen");
	}

	public void HighScoresScreen() {
		SceneManager.LoadScene ("HighScores");
	}

	public void ClearScores(){
		PlayerPrefs.DeleteAll ();
	}

	public void ExitGame() {
		Application.Quit;
	}
}
