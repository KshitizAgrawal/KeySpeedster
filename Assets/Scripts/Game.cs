using UnityEngine;
using System.Collections;


[System.Serializable]
public class Game { 

	public static Game current;
	public int coins=0;

	public Game (int score) {
		coins = coins + score;
	}

}
