using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ShowParagraph : MonoBehaviour {

	//private LoadScene ls;
	public Text txt, input, score;
	public static string paragraph="Fuck off";
	public GameObject canvas, scoreboard;

	// Use this for initialization
	void Start () {
		canvas.SetActive (true);
		scoreboard.SetActive (false);
		txt.text = paragraph;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (input.text == paragraph) {
			Timer.timer = 60.0f;
			score.text = "Congratulations!!!" + "\n" + "You WON";
			canvas.SetActive (false);
			scoreboard.SetActive (true);
		}*/
		if (Timer.timer <= 0f) {
			showScore ();
		}
		if (Input.GetKey(KeyCode.Home)){
			//Home button pressed! write every thing you want to do
		}
		if (Input.GetKey(KeyCode.Escape)){
			//Escape button codes
			showScore();
		}
		if(Input.GetKey(KeyCode.Menu)){
			Application.Quit();
		}
	}

	//on game over
	public void showScore() {
		SaveToFile.completionTime = 30.0f - Timer.timer;
		Timer.timer = 30.0f;
		double points;
		points = CalculateSimilarity (input.text, paragraph);		//compute accuracy
		SaveToFile.accuracy = (float)points;						//save current accuracy to log
		if ((float)points > Game.highscores [LoadScene.level]) {
			Game.highscores [LoadScene.level] = (float)points;
		}
		Game.points += (int)(points * 100);
		if (points >= 0.7) {
			unlockLevel ();
			SaveToFile.completed = true;
			score.text = "Nailed it!!" + "\n" + "Your Score: " + points;
		} else if (points >= 0.4) {
			SaveToFile.completed = false;
			score.text = "IE is faster than you" + "\n" + "Your Score: " + points;
		} else {
			SaveToFile.completed = false;
			score.text = "Mr. Slow" + "\n" + "Your Score: " + points;
		}
		canvas.SetActive (false);
		scoreboard.SetActive (true);
		SaveToFile save = new SaveToFile();
		SaveLoad.Save ();
	}

	//if tryagain button is pressed
	public void tryAgain() {
		canvas.SetActive (true);
		scoreboard.SetActive (false);
		int num = UnityEngine.Random.Range (0, 23);
		num %= 4;
		Debug.Log ("num is " + num);
		SaveToFile.level = num = 4*(LoadScene.level-1) + num+1;
		ShowParagraph.paragraph = Paragraphs.dict [num];
		SceneManager.LoadScene("Levels");
	}

	//if main menu button is pressed
	public void goBack() {
		SceneManager.LoadScene ("MainMenu");
	}

	private static void unlockLevel() {
		if (LoadScene.level == 1) {
			Game.levels [1] = 1;
		}
		else if (LoadScene.level == 2) {
			Game.levels [2] = 1;
		}
	}

	//computer percentage similarirty between two strings source and target
	public static double CalculateSimilarity(string source, string target)
	{
		if (string.IsNullOrEmpty(source))            
			return string.IsNullOrEmpty(target) ? 1: 0;            

		if (string.IsNullOrEmpty(target))            
			return string.IsNullOrEmpty(source) ? 1 : 0;            

		double stepsToSame = ComputeLevenshteinDistance(source, target);
		return (1.0 - (stepsToSame / (double)Math.Max(source.Length, target.Length)));
	}

	//Computer minimum conversion required to equate source and target
	public static int ComputeLevenshteinDistance(string source, string target)
	{
		if (string.IsNullOrEmpty(source))            
			return string.IsNullOrEmpty(target) ? 0 : target.Length;

		if (string.IsNullOrEmpty(target))
			return string.IsNullOrEmpty(source) ? 0 : source.Length;

		int sourceLength = source.Length;
		int targetLength = target.Length;

		int[,] distance = new int[sourceLength + 1, targetLength + 1];

		// Step 1
		for (int i = 0; i <= sourceLength; distance[i, 0] = i++) ;
		for (int j = 0; j <= targetLength; distance[0, j] = j++) ;

		for (int i = 1; i <= sourceLength; i++)
		{
			for (int j = 1; j <= targetLength; j++)
			{
				// Step 2
				int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

				// Step 3
				distance[i, j] = Math.Min(
					Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1),
					distance[i - 1, j - 1] + cost);
			}
		}

		return distance[sourceLength, targetLength];
	}
}
