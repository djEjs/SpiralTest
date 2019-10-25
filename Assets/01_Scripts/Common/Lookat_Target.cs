using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat_Target : MonoBehaviour
{
	public Transform target;
	public Vector2 offset;
	Transform tr;

	private void Awake()
	{
		tr = transform;
		StartCoroutine("cUpdate");
	}
	IEnumerator cUpdate()
	{
		while (true)
		{
			var offsetPos = new Vector3(offset.x, offset.y);
			Common.Lookat(tr, target.localPosition + offsetPos);
			yield return null;
		}
	}
}
