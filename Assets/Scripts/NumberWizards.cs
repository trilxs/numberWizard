using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max, min, guess;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
		
		max = max + 1;
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, and return = equal");
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down arrow pressed"); 
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}
	
	void NextGuess() {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, and return = equal");
	}
}
