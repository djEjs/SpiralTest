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

	Transform tr;
	public float rad_c;
	public Vector3 scale_c;

	private void Awake()
	{
		tr = transform;
	}
	private void Start()
	{
		rad_c = rad;
		scale_c = tr.localScale;
	}

	private void Update()
	{
		tr.localPosition = Common.ConvertPos(x * Mathf.Deg2Rad, y, rad);

		if (x > 360) x -= 360;
		if (x < 0) x += 360;
	}
	private void SizeUp()
	{
		rad = rad_c + scale_c.y * 0.5f;
		tr.localScale = Vector3.one * 0.5f;
	}
	private void SizeDown()
	{
		rad = rad_c;
		tr.localScale = scale_c;
	}
}
