using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
	public GameObject block;

    void Start()
    {
		List<GameObject> Groups = new List<GameObject>();

		for (int i = 0; i < 120; i++)
		{
			GameObject group = new GameObject();
			group.name = "Group" + i.ToString("D2");
			group.transform.parent = transform;

			float blocksize_x = 18 * 0.5f;

			int groupcount = Random.Range(1, 12);
			float interval = Random.Range(1, 360);
			
			// x
			for (int j = 0; j < 24; j++)
			{
				Test b = Instantiate(block, Vector3.zero, Quaternion.identity).GetComponent<Test>();
				b.name = "Block_" + i.ToString("D2") + "_" + j.ToString("D2");
				b.transform.parent = group.transform;
				b.x = j * blocksize_x
					+ i * interval;
				b.y = -30 + i * 0.5f;
				b.rad = 2.8f;
			}
		}
		//      for(int i = 0; i < 120; i++)
		//{
		//	GameObject group = new GameObject();
		//	group.name = "Group" + i.ToString("D2");
		//	group.transform.parent = transform;

		//	float blocksize_x = 16 * 0.5f;

		//	int groupcount = Random.Range(1, 12);
		//	float dist_betweenblocks = blocksize_x * (groupcount + 1);
		//	float interval = Random.Range(1, 18);

		//	for (int c = 0; c < groupcount; c++)
		//	{
		//		// x
		//		for (int j = 0; j < 36 / groupcount; j++)
		//		{
		//			Test b = Instantiate(block, Vector3.zero, Quaternion.identity).GetComponent<Test>();
		//			b.name = "Block_" + i.ToString("D2") + "_" + j.ToString("D2");
		//			b.transform.parent = group.transform;
		//			b.x = j * blocksize_x
		//				+ c * dist_betweenblocks
		//				+ i * interval;
		//			b.y = -30 + i * 0.5f;
		//			b.rad = 2.8f;
		//		}
		//	}
		//}
	}
}
