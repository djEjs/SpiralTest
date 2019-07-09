using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
	public GameObject block;

    void Start()
    {
		List<GameObject> Groups = new List<GameObject>();
		// y
        for(int i = 0; i < 60; i++)
		{
			GameObject group = new GameObject();
			group.name = "Group" + i.ToString("D2");
			group.transform.parent = transform;

			float dist_betweenblocks = Random.Range(1,180);
			// x
			for(int j = 0; j < 17; j++)
			{
				Test b = Instantiate(block, Vector3.zero, Quaternion.identity).GetComponent<Test>();
				b.name = "Block_" + i.ToString("D2") + "_" + j.ToString("D2");
				b.transform.parent = group.transform;
				b.x = j * 16 + i * dist_betweenblocks;
				b.y = -30 + i;
				b.rad = 2.8f;
			}
		}
    }
}
