using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	#region PUBLIC_VARIABLES
	public EnemyMove enemyMove;
	public EnemyData[] enemyData;
	public static GameManager Instance;
	public int level;
	#endregion
	#region UNITY_CALLBACKS
	void Awake(){
		Instance = this;
	}
	void Start () {
		level = GamePlayView.Instance.currentActivePanel;
		enemyMove.data = enemyData [level];
		EventManager.RaiseOnTextChange ();
	}
	void OnEnable(){
		EventManager.onLevelChange += ChangeEnemyData;
	}
	void OnDisable(){
		EventManager.onLevelChange -= ChangeEnemyData;
	}
	#endregion
	#region PRIVATE_FUNCTIONS
	void ChangeEnemyData(){
		if (level > enemyData.Length) {
			level = enemyData.Length;
		}
		if (level < 0) {
			level = 0;
		}
		level = GamePlayView.Instance.currentActivePanel;
		enemyMove.data = enemyData [level];
		EventManager.RaiseOnTextChange ();
	}
	#endregion
}
