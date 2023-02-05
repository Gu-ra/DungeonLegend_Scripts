using System;
using UnityEngine;

namespace Player_
{
	public class Player : MonoBehaviour, IDamagable
	{
		//プレイヤーのHPオーディオソース
		private void Start()
		{
			this.audioSource = base.GetComponent<AudioSource>();
			this.current_hp = this.hp_max;
		}

		public void AddDamage(float damage)
		{
			if (damage == 10f || damage == 50f)
			{
				this.audioSource.Play();
			}
			this.current_hp -= damage;
		}

		public float hp_max;

		public float current_hp;

		private AudioSource audioSource;
	}
}
