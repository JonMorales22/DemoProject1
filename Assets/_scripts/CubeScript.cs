using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	/// <summary>
	/// Simple script used to keep track of the score and display it to the player
	/// </summary>

	public GameObject display;

	public int score;

	void Update () {
		display.GetComponent<TextMesh> ().text = score.ToString();
	}

	void OnMouseDown() {
		score++;
	}
}
