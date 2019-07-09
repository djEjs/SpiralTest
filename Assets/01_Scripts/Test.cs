using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	[Range(0,360)]
	public float x;
	[Range(0, 30)]
	public float y;
	[Range(0.1f, 10)]
	public float rad;

	private void Update()
	{
		transform.position = Common.ConvertPos(x * Mathf.Deg2Rad, y, rad);

		if (x > 360) x -= 360;
		if (x < 0) x += 360;
	}
	private void SizeUp()
	{
		rad = 3.3f;
		transform.localScale = Vector3.one;
	}
	private void SizeDown()
	{
		rad = 2.8f;
		transform.localScale = Vector3.one - Vector3.forward * 0.9f;
	}
}
