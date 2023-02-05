using System;
using System.Collections;
using UnityEngine;

namespace Player_
{
	public class Respawn : MonoBehaviour
	{
		//チェックポイントでリスポーン処理
		private void Start()
		{
			this.audioSource = base.GetComponent<AudioSource>();
		}

		private void Update()
		{
			if (this.Respawnflg)
			{
				base.StartCoroutine("RespawnPlayer");
			}
		}

		public IEnumerator RespawnPlayer()
		{
			this.player.SetActive(false);
			this.player.transform.position = this.RespawnObject[RespawnCounter.RespawnCount].transform.position;
			this.audioSource.Play();
			yield return new WaitForSeconds(3f);
			this.player.SetActive(true);
			this.Respawnflg = false;
			yield break;
		}

		[SerializeField]
		private GameObject player;

		[SerializeField]
		private GameObject[] RespawnObject;

		private AudioSource audioSource;

		public bool Respawnflg;
	}
}
