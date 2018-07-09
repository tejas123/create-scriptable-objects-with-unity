using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	#region PUBLIC_VARIABLES
	public EnemyData data;
	//public string name;
	//public int moveSpeed;
	//public Color color;
	//public string colorName; 
	public SpriteRenderer spriterendere;
	#endregion

	#region PRIVATE_VARIABLES
	private float speed;
	Vector3 newPosition;
	#endregion

	#region UNITY_CALLBACKS
	void Update () {
		ChangeSpeed();
		gameObject.name = name;
		spriterendere.color = data.color;
		newPosition=transform.position;
		newPosition.y = Mathf.Sin (Time.time) * speed;
		transform.position = newPosition;
	}
	#endregion

	#region PROVATE_METHODS
	private void ChangeSpeed(){
		speed = Mathf.MoveTowards (speed,data.moveSpeed,Time.deltaTime);
	}
	#endregion
}
