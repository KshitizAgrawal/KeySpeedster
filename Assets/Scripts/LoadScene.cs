/* This script is attached to the main camera of main menu scene. 
 * 	It handles all main menu button methods.
 */
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

	public GameObject menu, levels, inst, highScore;			//canvas of menu, levels, and instruction
	public Text txt;								//instruction text
	public static int level;						//level selected by the user
	public Sprite locked, unlocked;
	public Button[] b;
	public Text[] scores;

	public void loadScene(int para) {
		if (Game.levels [para - 1] == 1) {
			//pickup a paragraph from dictionary to show
			level = para;
			int num = Random.Range (0, 23);
			num %= 4;
			Debug.Log ("num is " + num);
			SaveToFile.level = num = 4*(level-1) + num+1;
			ShowParagraph.paragraph = Paragraphs.dict [num];
			SceneManager.LoadScene ("Levels");
		}
	}
	public void quit() {
		Application.Quit ();
	}

	void Start() {
		SaveLoad.Load ();
		menu.SetActive (true);
		levels.SetActive (false);
		txt.text = "1. You have to complete the given paragraph in the given time\n" +
					"2. Next level will unlock on successful completion on current level\n" +
					"3. You can increase your vocabulary by getting more than 0.9 accuracy.\n" +
					"4. A new word with its meaning will show up in the above mentioned case.\n" +
					"BEST OF LUCK";
		if(Paragraphs.dict.Count==0)
			Paragraphs.addParagraphs ();
		for (int i = 0; i < 3; i++) {
			if (Game.levels [i] == 1) {
				b[i].image.sprite = unlocked; 
			} else {
				b[i].image.sprite = locked;
			}
		}
	}

	//activate levels canvas
	public void showLevels() {
		menu.SetActive (false);
		levels.SetActive (true);
	}

	//activate instructions canvas
	public void instructions() {
		menu.SetActive (false);
		inst.SetActive (true);	
	}

	//activate highscore canvas
	public void showScores() {
		menu.SetActive (false);
		highScore.SetActive (true);
		for (int i = 0; i < 3; i++) {
			scores [i].text = Game.highscores [i].ToString();
		}
	}

	//activate main menu canvas
	public void goback() {
		menu.SetActive (true);
		inst.SetActive (false);
		highScore.SetActive (false);
		levels.SetActive (false);
	}

	//for android default buttons
	void update() {
		if (Input.GetKey(KeyCode.Home)){
			//Home button pressed! write every thing you want to do
		}
		if (Input.GetKey(KeyCode.Escape)){
			//Escape button code
			goback();
		}
		if(Input.GetKey(KeyCode.Menu)){
			Application.Quit();
		}
	}
}
