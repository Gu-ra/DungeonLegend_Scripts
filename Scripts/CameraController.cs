using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	//プレイヤーを追従するカメラ
	private void Start()
	{
		this.offset = base.transform.position - this.player.transform.position;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
		base.transform.position = this.player.transform.position + this.offset + this.pos;
	}

	public GameObject player;

	private Vector3 offset;

	private Vector3 pos = new Vector3(0f, 0f);
}
