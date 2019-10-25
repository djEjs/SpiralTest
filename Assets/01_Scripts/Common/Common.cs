using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Common
{
	static public float PI { get { return Mathf.PI; } }
	static public float Sin(float angle) { return Mathf.Sin(angle); }
	static public float Cos(float angle) { return Mathf.Cos(angle); }
	static public float Tan(float angle) { return Mathf.Tan(angle); }
	static public float Atan2(float y, float x) { return Mathf.Atan2(y, x); }

	static public Vector3 ConvertPos(Vector2 pos, float rad)
	{
		return ConvertPos(pos.x, pos.y, rad);
	}
	static public Vector3 ConvertPos(float x, float y, float rad)
	{
		float _x = 0;
		float _y = y;
		float _z = 0;

		_x = -rad * Sin(x);
		_z = rad * Cos(x);

		return new Vector3(_x, _y, _z);
	}
	static public void Lookat(Transform tr, Vector3 TargetPos) { Lookat(tr, TargetPos, Vector3.up); }
	static public void Lookat(Transform tr, Vector3 TargetPos, Vector3 up)
	{
		tr.LookAt(TargetPos, up);
	}
}
