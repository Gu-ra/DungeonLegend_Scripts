using System;
using UnityEngine;
using UnityEngine.UI;

namespace Player_
{
	public class HPText : MonoBehaviour
	{
		//HPテキスト
		private void Start()
		{
			this.player_hp = this.player.gameObject.GetComponent<Player>();
		}

		private void Update()
		{
			this.hpcheck(this.player_hp.current_hp);
		}

		private void hpcheck(float hp)
		{
			hp = (float)((int)hp);
			base.GetComponent<Text>().text = "HP: " + hp.ToString();
		}

		private Player player_hp;

		public GameObject player;
	}
}
