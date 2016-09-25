using UnityEngine;
using System.Collections;

public class welcomeScript : MonoBehaviour {

	/// <summary>
	/// Searches player prefs and deletes any "CurrentPlayer." If this isn't deleted, issues occur later when the high scores are displayed.
	///  Wanted to find a better solution this issue, but whatever....
	/// </summary>
	void Start () {
		PlayerPrefs.DeleteKey ("247127CurrentPlayer");	
	}

}
