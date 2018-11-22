using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text gameTimerText;
    float gameTimer = 0f;
    
	
	// Update is called once per frame
	void Update () {
        gameTimer += Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;

        string timerString = string.Format("{1:00}:{2:00}", minutes, seconds);

        gameTimerText.text = timerString;
	}
}
