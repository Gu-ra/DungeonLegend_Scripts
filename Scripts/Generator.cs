using System;
using System.Collections;
using UnityEngine;

public class Generater : MonoBehaviour
{
	//オブジェクトを一定時間ごとに生成して飛ばす
	private void Start()
	{
		base.StartCoroutine(this.Generate());
		this.pos = new Vector2(base.transform.position.x - 16f, base.transform.position.y);
	}

	private IEnumerator Generate()
	{
		for (;;)
		{
			Object.Instantiate<GameObject>(this.Generating, this.pos, base.transform.rotation);
			yield return new WaitForSeconds(this.time);
		}
		yield break;
	}

	[SerializeField]
	private GameObject Generating;

	[SerializeField]
	private float time;

	private Vector2 pos;
}
