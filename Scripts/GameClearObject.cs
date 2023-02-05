using System;
using UnityEngine;

public class GameClearObject : MonoBehaviour
{
	//触れるとゲームクリアするオブジェクト
	private void OnTriggerEnter2D(Collider2D col)
	{
		GameClear.Clearflg = true;
		Object.Destroy(base.gameObject);
	}
}
