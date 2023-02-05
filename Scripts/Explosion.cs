using System;
using UnityEngine;

public class Explosion : MonoBehaviour
{
	//爆発アニメーション
	private void OnAnimationFinish()
	{
		Object.Destroy(base.gameObject);
	}

	//当たり判定
	private void OnTriggerEnter2D(Collider2D col)
	{
		IDamagable component = col.gameObject.GetComponent<IDamagable>();
		if (component != null)
		{
			component.AddDamage(this.ExplosionDamage);
		}
	}

	[SerializeField]
	private float ExplosionDamage = 100f;
}
