using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	[Range(0,100)]
	public float x;
	[Range(0, 30)]
	public float y;
	[Range(0, 10)]
	public float rad;

	private void Update()
	{
		transform.position = Common.ConvertPos(Common.PI * x * Mathf.Deg2Rad, y, rad);
	}
}
