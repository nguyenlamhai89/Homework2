using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Text displaytext;
	public Button YesButton;
	public Button LowerButton;
	public Button HigherButton;
	public Button PlayAgainButton;


	int number;
	int guesscount;
	string guess;
	int max = 100;
	int min = 0;


	void Start () 
	{
		PlayAgain ();
		Lower ();
		Higher ();
		Yes ();
		PlayAgain ();
	}

	public void PlayAgain()
	{
		number = Random.Range (min, max);
		displaytext.text = "Is it number " + number + " ?";
		YesButton.gameObject.SetActive (true);
		LowerButton.gameObject.SetActive (true);
		HigherButton.gameObject.SetActive (true);
		PlayAgainButton.gameObject.SetActive (false);
		guesscount = 1;
	}

	public void Yes()
	{
		displaytext.text = "The computer takes " + guesscount + " times to guess your number";
		YesButton.gameObject.SetActive (false);
		LowerButton.gameObject.SetActive (false);
		HigherButton.gameObject.SetActive (false);
		PlayAgainButton.gameObject.SetActive (true);
		guesscount = 0;
	}

	public void Lower()
	{	
		max = number - 1;
		number = Random.Range (min, max);
		if (number - 1 < 0) {
			number = 0;
		}
		displaytext.text = "Is it number " + number + " ?";
		YesButton.gameObject.SetActive (true);
		LowerButton.gameObject.SetActive (true);
		HigherButton.gameObject.SetActive (true);
		PlayAgainButton.gameObject.SetActive (false);
		guesscount++;
	}

	public void Higher()
	{
		min = number + 1;
		number = Random.Range (min, max);
		if (number + 1 > 100) {
			number = 100;
		}
		displaytext.text = "Is it number " + number + " ?";
		YesButton.gameObject.SetActive (true);
		LowerButton.gameObject.SetActive (true);
		HigherButton.gameObject.SetActive (true);
		PlayAgainButton.gameObject.SetActive (false);
		guesscount++;
	}
}
