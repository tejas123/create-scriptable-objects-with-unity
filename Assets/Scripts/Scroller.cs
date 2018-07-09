using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scroller : MonoBehaviour {
	#region PUBLIC_VARIABLES

	public static Scroller Instance;
	
	public RectTransform parent;
	public RectTransform[] rects;
	public ScrollRect scroll;
	public float distance;
	#endregion

	#region PRIVATE_VARIABLES

	private Vector3 startPos;
	private Vector3 endPos;
	
	private Coroutine lerpCoroutine = null;
	private bool isCoroutineRunning;
	private RectTransform tempRect;
	
	#endregion
	#region UNITY_CALLBACKS

	private void Awake()
	{
		Instance = this;
	}
	void Start()
	{
		distance = Vector3.Distance(rects[0].position, rects[1].position);
		
	}
	
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && !isCoroutineRunning)
		{
			startPos = parent.position;
		}
		
		if (Input.GetMouseButtonUp(0) && !isCoroutineRunning)
		{
			
			if (parent.position.x > startPos.x)
			{
				endPos = parent.position;
				lerpCoroutine = StartCoroutine(lerp(-1));
				GamePlayView.Instance.SetCurrentActive(-1);
				
			}
			else if (parent.position.x < startPos.x)
			{
				endPos = parent.position;
				lerpCoroutine = StartCoroutine(lerp(1));
				GamePlayView.Instance.SetCurrentActive(1);
			}
			
		}
	}
	#endregion
	#region CO_ROUTINES

	public IEnumerator lerp(int direction)
	{
		scroll.enabled = false;
		isCoroutineRunning = true;
		
		float i = 0;
		float rate = 1 / 1f;

		endPos = transform.position;

		while (i < 1)
		{
			i += Time.deltaTime * rate;
		
			transform.position = Vector3.Lerp(endPos, startPos + Vector3.left * distance * direction, i);
			
			
			yield return 0;
		}
		scroll.enabled = true;
		isCoroutineRunning = false;
	}
	#endregion


}
