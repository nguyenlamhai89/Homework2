using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton1;
	public Text hintText;
	public Button hintButton;
	// Use this for initialization
	public string levelContent = "LEVELS";
	public string levelNumber1;
	public string levelAnswer1 = "kabul";

	string answer;


	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine1 ());
	}





	public void GetInput1(){
		answer = inputField.text;
		CheckAnswerLevel1 (answer);
	}
		



	public void CheckAnswerLevel1 (string answer) {
		if (answer == levelAnswer1) {
			hintText.text = "Yayyy";
			hintText.color = Color.green;
			SceneManager.LoadScene (2);

			//TODO: Change scene

		} else {
			hintText.text = "Wrongg";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}

	}
		



	IEnumerator ChangeLevelTextRoutine1()
	{
		while (true) {
			levelText.text = levelContent;
			//wait 2 secs
			yield return new WaitForSeconds (1f);
			levelText.text = levelNumber1;
			yield return new WaitForSeconds (1f);
		}

	}
}
