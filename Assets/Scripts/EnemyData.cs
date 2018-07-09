using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName="EnemyData" ,menuName="Enemy Data")]
public class EnemyData : ScriptableObject {

	#region PUBLIC_VERIABLE

	public string name;
	public int moveSpeed;
	public Color color;
	public string colorName; 

	#endregion
}
