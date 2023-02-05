using System;
using UnityEngine;

public class Spike : MonoBehaviour
{
	//触れるとダメージを与えるトゲ
	private void Start()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		IDamagable component = col.gameObject.GetComponent<IDamagable>();
		if (component != null)
		{
			if (col.gameObject.tag != "Bomb")
			{
				this.audioSource.Play();
			}
			component.AddDamage(this._attackPoint);
		}
	}

	[SerializeField]
	private float _attackPoint = 500f;

	private AudioSource audioSource;
}
