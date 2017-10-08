using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max; 
	int min; 
	int guess;
	int maxGuessesAllowed=10;
	public Text text;
	void Start ()
		{
		StartGame ();	
		}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
	
	


		max = max + 1;
	}

	void nextGuess(){
		guess=(max+min)/2;
		text.text = guess.ToString();

		maxGuessesAllowed--;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("win");
		}
	}

	public void GuessHigher(){
		min=guess;
		nextGuess ();

	}
	public void GuessLower(){
		max=guess;
		nextGuess ();
	}





}