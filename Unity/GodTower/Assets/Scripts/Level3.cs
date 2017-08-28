using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour {

	public Text levelText;
	public InputField inputField;
	public Button submitButton3;
	public Text hintText;
	public Button hintButton;
	// Use this for initialization
	public string levelContent = "LEVELS";
	public string levelNumber3;
	public string levelAnswer3 = "evilcat";

	string answer;


	void Start () 
	{
		levelText.text = levelContent;
		StartCoroutine (ChangeLevelTextRoutine3 ());
	}





	public void GetInput3(){
		answer = inputField.text;
		CheckAnswerLevel3 (answer);
	}




	public void CheckAnswerLevel3 (string answer){
		if (answer == levelAnswer3) {
			hintText.text = "Yayyy";
			hintText.color = Color.green;
			//TODO: Change scene
			SceneManager.LoadScene (0);
		}else{
			hintText.text = "Wrongg";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}

	}




	IEnumerator ChangeLevelTextRoutine3()
	{
		while (true) {
			levelText.text = levelContent;
			//wait 2 secs
			yield return new WaitForSeconds (1f);
			levelText.text = levelNumber3;
			yield return new WaitForSeconds (1f);
		}

	}
}
