using UnityEngine;
using System.Collections;


[System.Serializable]
public class Game { 

	public static Game current;
	public static int[] levels = new int[3] {1, 0, 0};
	public static int points = 0;
	public static float[] highscores = new float[3] {0.0f, 0.0f, 0.0f};

	/*public Game (int score) {
		coins = coins + score;
	}*/

	public static int getLevel(int i) {
		return levels [i-1];
	}

	public static int getpoints() {
		return points;
	}

	public static float getHighscore(int i) {
		return highscores [i-1];
	}
}
