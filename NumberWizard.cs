using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max; 
	int min; 
	int guess;
	void Start ()
		{
		StartGame ();	
		}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
	
		print ("=======================================");
		print ("         Welcome to NumberWizard       ");

		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest Number you can pick is " + max);
		print ("The lowest Number you can pick is " + min);
		
		print ("Is the number higher or lower than "+guess+ " ?");
		print ("Up arrow for higher, down for lower, return for equal");
		max = max + 1;
	}

	void nextGuess(){
		guess=(max+min)/2;
		print ("hiher or lower than "+guess);
		print ("Up arrow for higher, down for lower, return for equal");
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed");
			min=guess;
			nextGuess ();
		}	
		 else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed");
			max=guess;
			nextGuess ();
		}	
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won");
	}
}
}