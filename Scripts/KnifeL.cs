using System;
using UnityEngine;

public class KnifeL : Knife
{
	//左に飛ぶナイフ
	public override void knifeMove()
	{
		Vector2 normalized = new Vector2(1f, 0f).normalized;
		this.rb2d.velocity = normalized * this.knifeSpeed * -1f;
	}
}
