using System;
using UnityEngine;

public class ClearSound : MonoBehaviour
{
	//クリアしたときSEを流す
	private void Start()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (this.flg && GameClear.Clearflg)
		{
			this.flg = false;
			this.audioSource.Play();
		}
	}

	private AudioSource audioSource;

	private bool flg = true;
}
