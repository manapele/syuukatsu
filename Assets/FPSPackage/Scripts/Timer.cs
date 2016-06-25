using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public int timeLimit = 20;
	private Text text;

	private float timeRemaining;
	private bool timerStarted;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		ResetTimer ();
		StartTimer ();
	}

	public void ResetTimer(){
		timeRemaining = timeLimit;
		timerStarted = false;
	}

	public void StartTimer(){
		timerStarted = true;
	}

		public void StopTimer(){
			timerStarted = false;
		}

		public  float GetTimeRemaining(){
		return timeRemaining;
	}

	// Update is called once per frame
	void Update () {
		if (timerStarted) {
			timeRemaining -= Time.deltaTime;
			if (timeRemaining <= 0) {

				timeRemaining = 0;
				timerStarted = false;
			}
		}
	
		text.text = "Time:" + ((int)timeRemaining).ToString();
	}
}
