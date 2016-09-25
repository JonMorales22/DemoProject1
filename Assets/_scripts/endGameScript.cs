using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class endGameScript : MonoBehaviour {
	public GameObject cube;

	public void endGame()
	{
		int score = cube.GetComponent<CubeScript> ().score;
		PlayerPrefs.SetInt ("247127CurrentPlayer",score);
		SceneManager.LoadScene ("HighScores");
	}
}
