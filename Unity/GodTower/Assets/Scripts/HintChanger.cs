using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintChanger : MonoBehaviour {

	public List<Image> hintList;
	public Button hintButton;

	int hintCurrentIndex = 0;

	public void OnHintButtonClick(){
		hintCurrentIndex++;

		if (hintCurrentIndex == hintList.Count - 1){
			hintButton.transform.localScale = new Vector3 (-1, 1, 1);
		}else{
			hintButton.transform.localScale = new Vector3 (1, 1, 1);
		}


		if (hintCurrentIndex == hintList.Count){
			hintCurrentIndex = 0;
		}
		for (int i = 0; i < hintList.Count; i++) {
			if (i == hintCurrentIndex){
				hintList [i].gameObject.SetActive (true);
			}else{
				hintList [i].gameObject.SetActive (false);
			}
		}
	}
}
