using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowParagraph : MonoBehaviour {

	private LoadScene ls;
	public Text txt, input, score;
	public static string paragraph="You are my love";
	public GameObject canvas, scoreboard;

	// Use this for initialization
	void Start () {
		canvas.SetActive (true);
		scoreboard.SetActive (false);
		txt.text = paragraph;
	}
	
	// Update is called once per frame
	void Update () {
		if (input.text == paragraph) {
			Timer.timer = 60.0f;
			score.text = "Congratulations!!!" + "\n" + "You WON";
			canvas.SetActive (false);
			scoreboard.SetActive (true);
		}
	}

	public void showScore() {
		Timer.timer = 60.0f;
		if (input.text == paragraph) {
			score.text = "Congratulations!!!" + "\n" + "You WON";
		} else {
			score.text = "Close" + "\n" + "Try luck next time";
		}
		canvas.SetActive (false);
		scoreboard.SetActive (true);
	}

	public void tryAgain() {
		canvas.SetActive (true);
		scoreboard.SetActive (false);
	}

	public void goBack() {
		SceneManager.LoadScene ("MainMenu");
	}
}
