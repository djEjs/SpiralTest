using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat_Target : MonoBehaviour
{
	public Transform target;
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
			Common.Lookat(tr, target.position);
			yield return null;
		}
	}
}
