using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowEnemyData : MonoBehaviour {
	#region PUBLIC_VARIABLES

	public Text leveNumber;
	public Text name;
	public Text color;
	public Text speed;
	#endregion
	#region PRIVATE_VARIABLE
	string levelText="Level: ";
	string nameText="Name: ";
	string colorText="Color: ";
	string speedText="Speed: ";
	#endregion
	#region UNITY_CALLBACKS
	void OnEnable(){
		EventManager.onTextChange += ShowData;

	}
	void OnDisable(){
		EventManager.onTextChange -= ShowData;
	}
	void start(){
		
	}
	void Update(){
		


	}

	#endregion
	 void ShowData(){
		
		leveNumber.text =levelText+ GamePlayView.Instance.currentActivePanel.ToString();
		name.text = nameText + GameManager.Instance.enemyMove.data.name;
		color.text = colorText+GameManager.Instance.enemyMove.data.colorName;
		speed.text =speedText+GameManager.Instance.enemyMove.data.moveSpeed;
	}
}
