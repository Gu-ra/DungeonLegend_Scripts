using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlay : MonoBehaviour
{
	//ゲームを開始する処理
	private void Start()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (Input.GetKey("joystick button 3"))//△ボタン
		{
			base.StartCoroutine(this.InputKey());
		}
	}

	private IEnumerator InputKey()
	{
		this.audioSource.Play();
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("MainScene");
		yield break;
	}

	private AudioSource audioSource;
}
