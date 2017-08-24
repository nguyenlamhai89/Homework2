using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton2;
	public Text hintText;
	public Button hintButton;
	// Use this for initialization
	public string levelContent = "LEVELS";
	public string levelNumber2;
	public string levelAnswer2 = "solomon";

	string answer;


	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine2 ());
	}





	public void GetInput2(){
		answer = inputField.text;
		CheckAnswerLevel2 (answer);
	}




	public void CheckAnswerLevel2 (string answer){
		if (answer == levelAnswer2) {
			hintText.text = "Yayyy";
			hintText.color = Color.green;
			//TODO: Change scene
		}else{
			hintText.text = "Wrongg";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}

	}




	IEnumerator ChangeLevelTextRoutine2()
	{
		while (true) {
			levelText.text = levelContent;
			//wait 2 secs
			yield return new WaitForSeconds (1f);
			levelText.text = levelNumber2;
			yield return new WaitForSeconds (1f);
		}

	}
}
