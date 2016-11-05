/*	this script handles the timer.
 *  manipulate timer in between the game.
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private LoadScene ls;
	public static float timer = 10.00f;
	public Text timeLeft;
	public GameObject canvas, scoreboard; 
	public static int flag, dec;

	// Use this for initialization
	void Start () {
		timer = 30.0f;
		flag = Random.Range(0, 30);
		flag = 30 - flag;
		dec = Random.Range(1, 30);
		dec%=2;
		//Debug.Log (flag);
		//Debug.Log (timer);
	}


	
	// Update is called once per frame
	void Update () {
		//Debug.Log (timer);
		timer -= Time.deltaTime;
		if ((int)timer == flag) {
			Debug.Log (flag);
			//timer -= 2 * Time.deltaTime;
			if (dec == 0)
				timer /= 2;
			else
				timer *= 2;
			flag = (int)timer+1;
		}
		float minutes = Mathf.Floor(timer / 60); 
		float seconds = Mathf.RoundToInt(timer%60);
		//if(minutes < 10) { minutes = "0" + minutes.ToString(); } 
		//if(seconds < 10) { seconds = "0" + Mathf.RoundToInt(seconds).ToString(); }
		timeLeft.text = minutes + ":" + seconds;
	}



}
