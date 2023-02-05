using System;
using UnityEngine;

public class Knife : MonoBehaviour, IDamagable
{
	// 主人公の投げるナイフ
	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody2D>();
		Object.Destroy(this.knife, this.destime);
	}

	private void Update()
	{
		this.knifeMove();
	}

	public virtual void knifeMove()
	{
		Vector2 normalized = new Vector2(1f, 0f).normalized;
		this.rb.velocity = normalized * this.knifeSpeed;
	}

	//接触するとダメージを与える
	protected void OnTriggerEnter2D(Collider2D col)
	{
		IDamagable component = col.gameObject.GetComponent<IDamagable>();
		if (component != null)
		{
			component.AddDamage(this._attackPoint);
		}
		Object.Destroy(this.knife);
	}

	public void AddDamage(float damage)
	{
		Object.Destroy(this.knife);
	}

	protected float destime = 4f;

	[SerializeField]
	protected GameObject knife;

	protected Rigidbody2D rb;

	[SerializeField]
	protected float knifeSpeed;

	[SerializeField]
	protected float _attackPoint = 10f;
}
