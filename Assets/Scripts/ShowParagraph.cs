using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

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
		/*if (input.text == paragraph) {
			Timer.timer = 60.0f;
			score.text = "Congratulations!!!" + "\n" + "You WON";
			canvas.SetActive (false);
			scoreboard.SetActive (true);
		}*/
		if (Timer.timer <= 0f) {
			showScore ();
		}
	}

	public void showScore() {
		Timer.timer = 10.0f;
		double points;
		points = CalculateSimilarity (input.text, paragraph);
		if (points>=0.5) {
			score.text = "Congratulations!" + "\n" + "Your Score: " + points;
		} else {
			score.text = "Very Close" + "\n" + "Your Score: " + points;
		}
		canvas.SetActive (false);
		scoreboard.SetActive (true);
	}

	public void tryAgain() {
		canvas.SetActive (true);
		scoreboard.SetActive (false);
		SceneManager.LoadScene("Levels");
	}

	public void goBack() {
		SceneManager.LoadScene ("MainMenu");
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
