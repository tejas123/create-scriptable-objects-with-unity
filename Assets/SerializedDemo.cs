using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializedDemo : MonoBehaviour {
	#region VARIABLES
	[SerializeField] private int a = 3;
	[SerializeField] private int b = 4;
	public float pi = 3.14f;
	private int myPrivate = 12;
	public static int myStatic = 13;
	public const int myConst=15;
	public readonly int myReadonly = 20;
	#endregion

	#region UNITY_CALLBACKS

	// Use this for initialization
	void Start () {
		Debug.Log ("Pi :"+pi+" MyPrivate :"+myPrivate+" MyStatic :"+myStatic);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			pi = 9;
			myPrivate = 45;
			myStatic = 89;
			GameObject.Instantiate(gameObject);
		}
	}
	#endregion
}
