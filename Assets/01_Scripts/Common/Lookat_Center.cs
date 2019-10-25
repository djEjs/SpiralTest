using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat_Center : MonoBehaviour
{
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
			Common.Lookat(tr, Vector3.up * tr.position.y);
			yield return null;
		}
	}
}
