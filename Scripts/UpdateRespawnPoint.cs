using System;
using UnityEngine;

public class UpdateRespwanPoint : MonoBehaviour
{
	//チェックポイント(復活場所)を更新
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (!this.ThroughFlg)
		{
			this.ThroughFlg = true;
			RespawnCounter.RespawnCount++;
			Debug.Log(RespawnCounter.RespawnCount);
		}
	}

	private bool ThroughFlg;
}
