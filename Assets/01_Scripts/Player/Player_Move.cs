using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
	[Range(0, 360)]
	public float x;
	[Range(-30, 30)]
	public float y;
	[Range(0.1f, 10)]
	public float rad;

	private void Update()
	{
		x += Input.GetAxis("Horizontal");
		y += Input.GetAxis("Vertical") * Mathf.Deg2Rad * 3.6f;

		transform.position = Common.ConvertPos(x * Mathf.Deg2Rad, y, rad);

		if (x > 360) x -= 360;
		if (x < 0) x += 360;
	}
}
