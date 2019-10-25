using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPosition : MonoBehaviour
{
	[Range(0, 360)]
	public float x;
	[Range(0, 30)]
	public float y;
	[Range(0.1f, 10)]
	public float rad;

	Transform tr;

	private void Awake()
	{
		tr = transform;
	}
	void Start()
    {
		StartCoroutine("Positioning");
    }

	IEnumerator Positioning()
	{
		while (true)
		{
			tr.localPosition = Common.ConvertPos(x * Mathf.Deg2Rad, y, rad);

			if (x > 360) x -= 360;
			if (x < 0) x += 360;
			yield return null;
		}
	}
}
