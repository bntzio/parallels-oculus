using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public void startGame(string name) {
		Application.LoadLevel(name);
	}
	
	public void loadSavedGame(string name) {
		Application.LoadLevel(name);
	}
	
	public void seeCredits(string name) {
		Application.LoadLevel(name);
	}
	
	
}
