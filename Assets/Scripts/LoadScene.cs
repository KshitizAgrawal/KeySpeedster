using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public GameObject menu, levels;

	public void loadScene(int para) {
		SaveToFile.level = para+1;
		ShowParagraph.paragraph = Paragraphs.dict [para];
		SceneManager.LoadScene ("Levels");
	}
	public void quit() {
		Application.Quit ();
	}

	void Start() {
		menu.SetActive (true);
		levels.SetActive (false);
		Paragraphs.addParagraphs ();
	}

	public void showLevels() {
		menu.SetActive (false);
		levels.SetActive (true);
	}
}
