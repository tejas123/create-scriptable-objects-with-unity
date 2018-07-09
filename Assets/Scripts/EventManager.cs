using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {
	#region PUBLIC_VARIABLES
	public delegate void OnLevelChange ();
	public static event OnLevelChange onLevelChange;

	public delegate void OnTextChange ();
	public static event OnTextChange onTextChange;
	#endregion

	#region PUBLIC_FUNCTIONS
	public static void RaiseOnLevelChange(){
		if (onLevelChange != null) {
			onLevelChange ();
		}
	}

	public static void RaiseOnTextChange(){
		if (onTextChange != null) {
			onTextChange ();
		}
	}
	#endregion
}
