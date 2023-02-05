using System;
using UnityEngine;

public class Bomb : MonoBehaviour, IDamagable
{
    //爆発し、ダメージを与える。また、ナイフなどでダメージを受けると即爆発
	private void Start()
	{
		this.anim = base.GetComponent<Animator>();
		base.Invoke("Delay", this.ExplosionTime);
	}


	private void Explosion()
	{
		Vector2 v = new Vector2(base.transform.position.x, base.transform.position.y);
		Object.Instantiate<GameObject>(this.explosion, v, base.transform.rotation);
		Object.Destroy(base.gameObject);
	}

	public void AddDamage(float damage)
	{
		if (damage < 100f)
		{
			this.anim.SetTrigger("Explode");
		}
	}

	private void Delay()
	{
		this.AddDamage(0f);
	}

	[SerializeField]
	private GameObject explosion;

	private Animator anim;

	[SerializeField]
	private float ExplosionTime;
}
