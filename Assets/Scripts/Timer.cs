using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private LoadScene ls;
	public static float timer = 60.00f;
	public Text timeLeft;

	// Use this for initialization
	void Start () {
		timer = 60.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0f) {
			timer = 60.0f;
			SceneManager.LoadScene ("MainMenu");
		}
		timer -= Time.deltaTime;
		float minutes = Mathf.Floor(timer / 60); 
		float seconds = Mathf.RoundToInt(timer%60);
		//if(minutes < 10) { minutes = "0" + minutes.ToString(); } 
		//if(seconds < 10) { seconds = "0" + Mathf.RoundToInt(seconds).ToString(); }
		timeLeft.text = minutes + ":" + seconds;
	}

}
