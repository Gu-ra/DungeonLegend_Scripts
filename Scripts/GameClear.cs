using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
	//ゲームクリア処理
	private void Start()
	{
		GameClear.Clearflg = false;
	}

	private void Update()
	{
		if (GameClear.Clearflg)
		{
			base.StartCoroutine(this.gameClear());
		}
	}

	private IEnumerator gameClear()
	{
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene("TitleScene");
		yield break;
	}

	public static bool Clearflg;
}
