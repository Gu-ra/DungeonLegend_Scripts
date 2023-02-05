using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoTitle : MonoBehaviour
{
	// タイトルに戻る処理
	private void Start()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (Input.GetKey("joystick button 9"))//Optionボタン
		{
			base.StartCoroutine(this.InputKey());
		}
	}

	private IEnumerator InputKey()
	{
		this.audioSource.Play();
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("TitleScene");
		yield break;
	}

	private AudioSource audioSource;
}
