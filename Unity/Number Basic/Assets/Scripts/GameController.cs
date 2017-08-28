using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Text displayText;
	public InputField inputfield;
	public Button PlayAgainButton;


	int numbertoguess;
	int guesscount;
	string guess;
	int guessInt;
	void Start () {
		PlayAgain ();
	}

	public void GetInput ()
	{
		guess = inputfield.text;
		guesscount++;
		CompareGuess ();
		inputfield.text = "";
		inputfield.ActivateInputField ();
	}

	public void CompareGuess()
	{
		guessInt = int.Parse (guess);
		if (guessInt > numbertoguess) {
			displayText.text = "Your guess is higher than our number";
		} else if (guessInt < numbertoguess) {
			displayText.text = "Your guess is lower than our number";
		} else {
			PlayAgainButton.gameObject.SetActive (true);
			displayText.text = "You win.It takes you " + guesscount + " times to guess";
		}
	}

	public void PlayAgain(){
		numbertoguess = Random.Range (0, 100);
		displayText.text = "Guess a number between 0 - 100 ";
		PlayAgainButton.gameObject.SetActive (false);
		guesscount = 0;
	}
}