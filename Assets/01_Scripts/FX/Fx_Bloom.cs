using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Fx_Bloom : MonoBehaviour
{
	PostProcessVolume vol;
	Bloom bloom;

	private void Awake()
	{
		vol = GetComponent<PostProcessVolume>();
		//bloom = vol.GetComponent<Bloom>();
		vol.profile.TryGetSettings<Bloom>(out bloom);
		StartCoroutine("BloomProcessing");
	}
	private IEnumerator BloomProcessing()
	{
		FloatParameter _float = bloom.intensity;
		while (true)
		{
			_float.Interp(bloom.intensity, Random.Range(1, 7), 0.1f);
			yield return null;
		}
	}
}
