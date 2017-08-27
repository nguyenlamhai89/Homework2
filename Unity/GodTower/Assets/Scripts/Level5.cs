using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton5;
	public Text hintText;
	public Button hintButton;
	// Use this for initialization
	public string levelContent = "LEVELS";
	public string levelNumber5;
	public string levelAnswer5;

	string answer;


	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine5 ());
	}





	public void GetInput5(){
		answer = inputField.text;
		CheckAnswerLevel5 (answer);
	}




	public void CheckAnswerLevel5 (string answer) {
		if (answer == levelAnswer5) {
			hintText.text = "Yayyy";
			hintText.color = Color.green;
			SceneManager.LoadScene (0);

			//TODO: Change scene

		} else {
			hintText.text = "Wrongg";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}

	}




	IEnumerator ChangeLevelTextRoutine5()
	{
		while (true) {
			levelText.text = levelContent;
			//wait 2 secs
			yield return new WaitForSeconds (1f);
			levelText.text = levelNumber5;
			yield return new WaitForSeconds (1f);
		}

	}
}
