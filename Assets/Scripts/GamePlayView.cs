using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayView : MonoBehaviour {
	#region PUBLIC_VARIABLES
	public static GamePlayView Instance;
	public int currentActivePanel;
	public bool isLevelChange;
	#endregion
	#region UNITY_CALLBACKS
	void Awake(){
		Instance = this;
	}
	#endregion

	#region PUBLIC_FUNCTION
	public int SetCurrentActive(int displacement)
	{

		currentActivePanel += displacement;
		if (currentActivePanel < 0)
		{
			currentActivePanel = 0;
		}
		if (currentActivePanel > 4)
		{
			currentActivePanel = 4;
		}
		EventManager.RaiseOnLevelChange ();

		return currentActivePanel;

		/*ActivePlayer.Instance.SetCurrentActivePlayer(currentActivePanel);
		ActivePlayer.Instance.Set(DataManager.Instance.playerItemData[currentActivePanel], currentActivePanel);*/



	}
	#endregion

}
