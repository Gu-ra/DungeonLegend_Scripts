using System;
using UnityEngine;

namespace Player_
{
	public class HP_Check : MonoBehaviour
	{
		//HPチェック
		public void Start()
		{
			this.player_hp = this.player.gameObject.GetComponent<Player>();
			this.respawn = base.gameObject.GetComponent<Respawn>();
			RespawnCounter.RespawnCount = 0;
		}

		public void Update()
		{
			this.hpcheck(this.player_hp.current_hp);
		}

		private void hpcheck(float hp)
		{
			if (hp <= 0f && !this.respawn.Respawnflg)
			{
				this.respawn.Respawnflg = true;
				this.player_hp.current_hp = this.player_hp.hp_max;
			}
		}

		private Player player_hp;

		public GameObject player;

		private Respawn respawn;
	}
}
