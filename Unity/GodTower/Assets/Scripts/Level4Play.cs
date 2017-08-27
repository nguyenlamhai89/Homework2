using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4Play : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton4;
	public Text hintText;
	public Button hintButton;
	// Use this for initialization
	public string levelContent = "LEVELS";
	public string levelNumber4;
	public string levelAnswer4 = "acup";

	string answer;


	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine4 ());
	}





	public void GetInput4(){
		answer = inputField.text;
		CheckAnswerLevel4 (answer);
	}




	public void CheckAnswerLevel4(string answer) {
		if (answer == levelAnswer4) {
			hintText.text = "Yayyy";
			hintText.color = Color.green;
			SceneManager.LoadScene (4);

			//TODO: Change scene

		} else {
			hintText.text = "Wrongg";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}

	}




	IEnumerator ChangeLevelTextRoutine4()
	{
		while (true) {
			levelText.text = levelContent;
			//wait 2 secs
			yield return new WaitForSeconds (1f);
			levelText.text = levelNumber4;
			yield return new WaitForSeconds (1f);
		}

	}
}
