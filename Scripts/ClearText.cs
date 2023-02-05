using System;
using UnityEngine;
using UnityEngine.UI;

public class ClearText : MonoBehaviour
{
	//クリア後に出現するテキスト
	private void Start()
	{
		this.text = base.GetComponent<Text>();
	}

	private void Update()
	{
		if (GameClear.Clearflg)
		{
			this.text.enabled = true;
		}
	}

	private Text text;
}
