using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private LoadScene ls;
	public static float timer = 10.00f;
	public Text timeLeft;
	public GameObject canvas, scoreboard; 
	public static int flag;

	// Use this for initialization
	void Start () {
		timer = 10.0f;
		flag = 0;
	}


	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer == 5.0f) {
			//Random rnd = new Random();
			flag = Random.Range(0,2);
			if (flag == 1) {
				timer -= 2 * Time.deltaTime;
			}
		}
		float minutes = Mathf.Floor(timer / 60); 
		float seconds = Mathf.RoundToInt(timer%60);
		//if(minutes < 10) { minutes = "0" + minutes.ToString(); } 
		//if(seconds < 10) { seconds = "0" + Mathf.RoundToInt(seconds).ToString(); }
		timeLeft.text = minutes + ":" + seconds;
	}



}
